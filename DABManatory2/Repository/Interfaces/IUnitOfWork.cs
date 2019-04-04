using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using DABMandatory2.Interfaces;
using DABMandatory2.Repository.Implementation;

namespace DABMandatory2.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Teacher> TeacherRepository { get; }
        IRepository<TeachingAssistant> TARepository { get; }
        IRepository<LectureDates> LecDateRepository { get; }
        IRepository<IsEnrolledTo> EnrollRepository { get; }
        IRepository<IsAssignedTo> IsAssignedRepository { get; }
        IRepository<HandIns> HandinRepository { get; }
        IRepository<Folder> FolderRepository { get; }
        IRepository<Deadlines> DeadlinesRepository { get; }
        IRepository<CourseResponsible> CRRepository { get; }
        IRepository<CourseContent> CourseContRepository { get; }
        IRepository<ContentArea> ContAreaRepository { get; }
        IRepository<Calendar> CalendarRepository { get; }
        IRepository<Assignments> AssignmentRepository { get; }
        StudentRepository StudentRepository { get; }
        // INSERT COURSE REPO HERE

        int Complete();
    }
}
