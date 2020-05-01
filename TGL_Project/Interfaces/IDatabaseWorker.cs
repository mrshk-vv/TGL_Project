using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.Interfaces
{
    public interface IDatabaseWorker
    {

        IEnumerable<Group> GetAllGroups();
        IEnumerable<Department> GetAllDepartments();
        IEnumerable<Position> GetAllPositions();
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsers(int facultyId, int departmentId, int groupId);
        IEnumerable<Faculty> GetFaculties();
        IEnumerable<News> GetNews();
        IQueryable<Student> GetAllStudents();
        IQueryable<Teacher> GetAllTeachers();

        bool GroupExists(int groupId);
        bool DepartmentExists(int departmentId);
        bool PositionExists(int positionId);

        IEnumerable<Group> GetGroupsOfDepartments(IEnumerable<Department> departments);
        IEnumerable<Department> GetDepartmentsByFaculty(Faculty faculty);
        IEnumerable<Department> GetDepartmentsByFaculty(int facultyId);
        IEnumerable<Group> GetGroupsByDepartment(Department department);
        IEnumerable<Group> GetGroupsByFaculty(Faculty faculty);
        IEnumerable<Group> GetGroupsByFaculty(int facultyId);
        IEnumerable<Group> GetGroupsByDepartment(int departmentId);

        Subject GetSubjectById(int subjectId);
        Faculty GetFacultyById(int facultyId);
        Department GetDepartmentById(int departmentId);
        Group GetGroupId(int groupId);
        Models.Task GetTaskById(int id);


    }
}
