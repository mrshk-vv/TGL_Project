﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using TGL_Project.Interfaces;
using TGL_Project.Models;

namespace TGL_Project.Services
{
    public class FileService : IFileService
    {

        private readonly IWebHostEnvironment _appEnvironment;
        private readonly DataBaseContext _dataBaseContext;
        private readonly UserManager<User> _userManager;

        public FileService(IWebHostEnvironment appEnvironment, UserManager<User> userManager, DataBaseContext dataBaseContext)
        {
            _appEnvironment = appEnvironment;
            _userManager = userManager;
            _dataBaseContext = dataBaseContext;
        }

        public async System.Threading.Tasks.Task DeleteAvatar(User user)
        {

            string lastAvatar = _appEnvironment.WebRootPath + user.AvatarPath;
            if (user.AvatarPath != "" && File.Exists(lastAvatar))
            {
                File.Delete(lastAvatar);
            }

            user.AvatarPath = "";
            await _userManager.UpdateAsync(user);

        }

        public async System.Threading.Tasks.Task<bool> UploadNewAvatar(User user, IFormFile uploadedFile)
        {

            if (uploadedFile != null)
            {

                string path = _appEnvironment.WebRootPath + "/files/users/" + user.Id + "/";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string lastAvatar = _appEnvironment.WebRootPath + user.AvatarPath;

                if (user.AvatarPath != "" && File.Exists(lastAvatar))
                {

                    File.Delete(lastAvatar);

                }

                using (FileStream fileStream = new FileStream(path + uploadedFile.FileName, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                user.AvatarPath = "/files/users/" + user.Id + "/" + uploadedFile.FileName;

                IdentityResult result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }

        public async System.Threading.Tasks.Task UploadTaskFile(Models.Task __task, IFormFile uploadedFile)
        {

            if (uploadedFile != null)
            {

                Models.Task task = _dataBaseContext.Task.FirstOrDefault(x => x.Id == __task.Id);
                string path = _appEnvironment.WebRootPath + "/files/tasks/" + task.Id + "/";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string lastFileName = _appEnvironment.WebRootPath + task.TheoryPath;

                if (task.TheoryPath != "" && File.Exists(lastFileName))
                {
                    File.Delete(lastFileName);

                }

                using (FileStream fileStream = new FileStream(path + uploadedFile.FileName, FileMode.Create))
                {

                    await uploadedFile.CopyToAsync(fileStream);
                }

                task.TheoryPath = "/files/tasks/" + task.Id + "/" + uploadedFile.FileName;

                _dataBaseContext.Task.Update(task);
                _dataBaseContext.SaveChanges();

            }
        }

        public async System.Threading.Tasks.Task UploadTaskSolutionFile(N_To_N_TaskStudent __model, IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {

                N_To_N_TaskStudent model = _dataBaseContext.N_To_N_TaskStudent.FirstOrDefault(x => x.Id == __model.Id);
                string path = _appEnvironment.WebRootPath + "/files/task_answers/" + model.Id + "/";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (FileStream fileStream = new FileStream(path + uploadedFile.FileName, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                model.SolutionPath = "/files/task_answers/" + model.Id + "/" + uploadedFile.FileName;

                _dataBaseContext.SaveChanges();

            }
        }

        // DEPRECATED
        public void CreateChatFile(Chat chat)
        {
            /*  chat.HistoryPath = _appEnvironment.WebRootPath + "/files/chats/" + chat.Id + "/";

              if (!Directory.Exists(chat.HistoryPath))
              {
                  Directory.CreateDirectory(chat.HistoryPath);
              }

              chat.HistoryPath += "messages.txt";

              if (!File.Exists(chat.HistoryPath)) 
              {
                  File.Create(chat.HistoryPath);
              }


              _dataBaseContext.Chat.Update(chat);
              _dataBaseContext.SaveChanges();*/

        }

        public void DeleteFile(string __path)
        {
            string path = _appEnvironment.WebRootPath + __path;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public byte[] Download(string path)
        {
            byte[] doc = new byte[0];
            doc = System.IO.File.ReadAllBytes(_appEnvironment.WebRootPath + path);
            return doc;
        }
    }
}
