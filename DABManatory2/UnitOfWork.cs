using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using DABMandatory2.Interfaces;
using DABMandatory2.Repository.Implementation;
using DABMandatory2.Repository.Interfaces;

namespace DABMandatory2
{
    public class UnitOfWork : IUnitOfWork
    {
        private StudentRepository _studentRepository;
        private IRepository<Assignments> _assignmentRepository;
        private IRepository<Calendar> _calendarRepository;
        private IRepository<ContentArea> _contAreaRepository;
        private IRepository<CourseContent> _courseContRepository;
        private IRepository<CourseResponsible> _CRRepository;
        private IRepository<Deadlines> _deadlineRepository;
        private IRepository<Folder> _folderRepository;
        private IRepository<HandIns> _handinRepository;
        private IRepository<IsAssignedTo> _isAssignedToRepository;
        private IRepository<IsEnrolledTo> _enrollRepository;
        private IRepository<LectureDates> _lecDateRepository;
        private IRepository<TeachingAssistant> _TARepository;
        private IRepository<Teacher> _teacherRepository;
        private CourseRepository _courseRepository;

        public CourseRepository CourseRepository =>
            _courseRepository ?? (_courseRepository = new CourseRepository(_bbContext));
        public StudentRepository StudentRepository => 
            _studentRepository ?? (_studentRepository = new StudentRepository(_bbContext));

        public IRepository<Assignments> AssignmentRepository =>
            _assignmentRepository?? (_assignmentRepository = new Repository<Assignments>(_bbContext));

        public IRepository<Calendar> CalendarRepository =>
            _calendarRepository ?? (_calendarRepository = new Repository<Calendar>(_bbContext));

        public IRepository<ContentArea> ContAreaRepository =>
            _contAreaRepository ?? (_contAreaRepository = new Repository<ContentArea>(_bbContext));

        public IRepository<CourseContent> CourseContRepository =>
            _courseContRepository ?? (_courseContRepository = new Repository<CourseContent>(_bbContext));

        public IRepository<CourseResponsible> CRRepository =>
            _CRRepository ?? (_CRRepository = new Repository<CourseResponsible>(_bbContext));

        public IRepository<Deadlines> DeadlinesRepository =>
            _deadlineRepository ?? (_deadlineRepository = new Repository<Deadlines>(_bbContext));

        public IRepository<Folder> FolderRepository =>
            _folderRepository ?? (_folderRepository = new Repository<Folder>(_bbContext));

        public IRepository<HandIns> HandinRepository =>
            _handinRepository ?? (_handinRepository = new Repository<HandIns>(_bbContext));

        public IRepository<IsAssignedTo> IsAssignedRepository =>
            _isAssignedToRepository ?? (_isAssignedToRepository = new Repository<IsAssignedTo>(_bbContext));

        public IRepository<IsEnrolledTo> EnrollRepository =>
            _enrollRepository ?? (_enrollRepository = new Repository<IsEnrolledTo>(_bbContext));

        public IRepository<LectureDates> LecDateRepository =>
            _lecDateRepository ?? (_lecDateRepository = new Repository<LectureDates>(_bbContext));

        public IRepository<TeachingAssistant> TARepository =>
            _TARepository ?? (_TARepository = new Repository<TeachingAssistant>(_bbContext));

        public IRepository<Teacher> TeacherRepository =>
            _teacherRepository ?? (_teacherRepository = new Repository<Teacher>(_bbContext));




        private BlackBoardContext _bbContext = new BlackBoardContext();
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _bbContext.Dispose();
                }
            }
            disposed = true;
        }
        
        public int Complete()
        {
            return _bbContext.SaveChanges();
        }
    }
}
