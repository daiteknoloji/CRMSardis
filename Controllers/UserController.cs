<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using CRMSardis.Data;
using CRMSardis.Models;

namespace CRMSardis.Controllers
{
    public class UserController
=======
using CRMSardis.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRMSardis.Controllers
{
    public class UserController : Controller
>>>>>>> 710e3ed (Proje dosyalarını ekledim)
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

<<<<<<< HEAD
        // Kullanıcıları Listeleme
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        // Kullanıcı Detayları
        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id) 
                   ?? throw new Exception("Kullanıcı bulunamadı.");
        }

        // Yeni Kullanıcı Ekleme
        public void CreateUser(User user)
        {
            if (user != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        // Kullanıcı Düzenleme
        public void UpdateUser(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Surname = user.Surname;
                existingUser.Email = user.Email;
                existingUser.Role = user.Role;

                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }
        }

        // Kullanıcı Silme
        public void DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }
=======
        // GET: /User
        public IActionResult Index()
        {
            // Veritabanındaki tüm kullanıcıları getir
            var users = _context.Users.ToList();
            return View(users);
>>>>>>> 710e3ed (Proje dosyalarını ekledim)
        }
    }
}
