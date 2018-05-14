﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolucionOfertas.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EntitiesOfertas : DbContext
    {
        public EntitiesOfertas()
            : base("name=EntitiesOfertas")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<COMUNA> COMUNA { get; set; }
        public virtual DbSet<DIRECCION> DIRECCION { get; set; }
        public virtual DbSet<PERFIL> PERFIL { get; set; }
        public virtual DbSet<PERSONA> PERSONA { get; set; }
        public virtual DbSet<PROVINCIA> PROVINCIA { get; set; }
        public virtual DbSet<REGION> REGION { get; set; }
    
        public virtual int COMUNA_PROCEDURE(string nOMBRE_COMUNA, string iD_PROVINCIA)
        {
            var nOMBRE_COMUNAParameter = nOMBRE_COMUNA != null ?
                new ObjectParameter("NOMBRE_COMUNA", nOMBRE_COMUNA) :
                new ObjectParameter("NOMBRE_COMUNA", typeof(string));
    
            var iD_PROVINCIAParameter = iD_PROVINCIA != null ?
                new ObjectParameter("ID_PROVINCIA", iD_PROVINCIA) :
                new ObjectParameter("ID_PROVINCIA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("COMUNA_PROCEDURE", nOMBRE_COMUNAParameter, iD_PROVINCIAParameter);
        }
    
        public virtual int DIRECCION_PROCEDURE(string cALLE_DIRECCION, Nullable<decimal> nRO_DIRECCION, string dEPTO_DIRECCION, string cOMUNA_ID)
        {
            var cALLE_DIRECCIONParameter = cALLE_DIRECCION != null ?
                new ObjectParameter("CALLE_DIRECCION", cALLE_DIRECCION) :
                new ObjectParameter("CALLE_DIRECCION", typeof(string));
    
            var nRO_DIRECCIONParameter = nRO_DIRECCION.HasValue ?
                new ObjectParameter("NRO_DIRECCION", nRO_DIRECCION) :
                new ObjectParameter("NRO_DIRECCION", typeof(decimal));
    
            var dEPTO_DIRECCIONParameter = dEPTO_DIRECCION != null ?
                new ObjectParameter("DEPTO_DIRECCION", dEPTO_DIRECCION) :
                new ObjectParameter("DEPTO_DIRECCION", typeof(string));
    
            var cOMUNA_IDParameter = cOMUNA_ID != null ?
                new ObjectParameter("COMUNA_ID", cOMUNA_ID) :
                new ObjectParameter("COMUNA_ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DIRECCION_PROCEDURE", cALLE_DIRECCIONParameter, nRO_DIRECCIONParameter, dEPTO_DIRECCIONParameter, cOMUNA_IDParameter);
        }
    
        public virtual int PERFIL_PROCEDURE(string pERFIL_NOMBRE)
        {
            var pERFIL_NOMBREParameter = pERFIL_NOMBRE != null ?
                new ObjectParameter("PERFIL_NOMBRE", pERFIL_NOMBRE) :
                new ObjectParameter("PERFIL_NOMBRE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PERFIL_PROCEDURE", pERFIL_NOMBREParameter);
        }
    
        public virtual int PROVINCIA_PROCEDURE(string nOMBRE_PROVINCIA, string iD_REGION)
        {
            var nOMBRE_PROVINCIAParameter = nOMBRE_PROVINCIA != null ?
                new ObjectParameter("NOMBRE_PROVINCIA", nOMBRE_PROVINCIA) :
                new ObjectParameter("NOMBRE_PROVINCIA", typeof(string));
    
            var iD_REGIONParameter = iD_REGION != null ?
                new ObjectParameter("ID_REGION", iD_REGION) :
                new ObjectParameter("ID_REGION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROVINCIA_PROCEDURE", nOMBRE_PROVINCIAParameter, iD_REGIONParameter);
        }
    
        public virtual int REGION_PROCEDURE(string nOMBRE_REGION)
        {
            var nOMBRE_REGIONParameter = nOMBRE_REGION != null ?
                new ObjectParameter("NOMBRE_REGION", nOMBRE_REGION) :
                new ObjectParameter("NOMBRE_REGION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("REGION_PROCEDURE", nOMBRE_REGIONParameter);
        }
    
        public virtual int PERSONA_PROCEDURE(string pERSONA_EMAIL, string pERSONA_RUT, string pERSONA_CONTRASENA)
        {
            var pERSONA_EMAILParameter = pERSONA_EMAIL != null ?
                new ObjectParameter("PERSONA_EMAIL", pERSONA_EMAIL) :
                new ObjectParameter("PERSONA_EMAIL", typeof(string));
    
            var pERSONA_RUTParameter = pERSONA_RUT != null ?
                new ObjectParameter("PERSONA_RUT", pERSONA_RUT) :
                new ObjectParameter("PERSONA_RUT", typeof(string));
    
            var pERSONA_CONTRASENAParameter = pERSONA_CONTRASENA != null ?
                new ObjectParameter("PERSONA_CONTRASENA", pERSONA_CONTRASENA) :
                new ObjectParameter("PERSONA_CONTRASENA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PERSONA_PROCEDURE", pERSONA_EMAILParameter, pERSONA_RUTParameter, pERSONA_CONTRASENAParameter);
        }
    }
}
