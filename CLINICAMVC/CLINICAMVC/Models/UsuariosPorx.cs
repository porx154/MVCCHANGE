using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Collections.ObjectModel;
using Microsoft.AspNet.Identity.EntityFramework;
namespace CLINICAMVC.Models
{
    public class UsuariosPorx:Manager
    {
        public UsuariosPorx(ApplicationDbContext context) 
            : base(context) 
        {

        }
        public string CrearUsuario(RegisterViewModel model)
        {
            try
            {
                var usuario = new ApplicationUser
                {
                    UserName = model.UserName,
                    EstadoUsuario = model.EstadoUsuario,
                    IdEmpleado = model.IdEmpleado
                };
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(Context));
                var result = userManager.Create(usuario, model.Password);
                if (result.Succeeded)
                {
                    var resultrol = userManager.AddToRole(usuario.Id, model.RolUsuario);
                    if (resultrol.Succeeded)
                    {
                        return usuario.Id;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public ApplicationUser BuscarUsuarioNombre(string NombUsuario)
        {
            try
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(Context));
                return userManager.FindByName(NombUsuario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}