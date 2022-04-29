using ApiKPITop500.Models;
using ApiKPITop500.ModelsLocales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ApiKPITop500.Controllers
{

    public class KIPTop500Controller : ApiController
    {
        KPIModel data = new KPIModel();



        [HttpGet]
        [Route("api/kpi/GetFaltantes/{idStore}/{IdConteo}")]
        public IHttpActionResult GetFaltantes_sp(int idStore, int IdConteo)
        {
            if (IdConteo == 1)
            {
                var result = data.Database.SqlQuery<Top500>("exec [KPI].[CBR_GetTop500Pendientes_SP] " + idStore);
                return Ok(result);
            }
            else
            {
                var result = data.Database.SqlQuery<Top500>("exec[KPI].[CBR_GetTop300Pendientes_SPrueba] " + idStore);
                return Ok(result);
            }



        }

        [HttpGet]
        [Route("api/kpi/ObtenerImportados/{idStore}/{FechaDesde}/{FechaHasta}/{Medicion}")]
        public IHttpActionResult getImportados(int idStore, string FechaDesde, string FechaHasta, int Medicion)

        {
                if (Medicion == 1)
            {

                  var TopList = data.Database.SqlQuery<Importados>("exec [CBR_TOP500] " + idStore + ",'" + FechaDesde + "'" + ",'" + FechaHasta + "'");

                    data.Database.CommandTimeout = 180;
                    return Ok(TopList);
            
            }

             if (Medicion == 2)
            {
                var TopList = data.Database.SqlQuery<Importados>("exec [CBR_IMPORTADOS] " + idStore + ",'" + FechaDesde + "'" + ",'" + FechaHasta + "'");


                return Ok(TopList);
            }

             else
            {
                return Ok();
            }

           
           

        }


        [HttpGet]
        [Route("api/kpi/GetDataFaltantesDisponibles/{idStore}/{idMedicion}")]
        public IHttpActionResult GetDataFaltantesDisponibles(int idStore, int idMedicion)
        {
            if (idMedicion == 1)
            {
                var result = data.Database.SqlQuery<Top500FaltantesDisponibles>("exec [KPI].[CBR_GetTop500Faltante_SP]" + idStore);

                return Ok(result);
            }

            else
            {
                var result = data.Database.SqlQuery<Top500FaltantesDisponibles>("exec [KPI].[CBR_GetTop300Faltantes_SP]" + idStore);

                return Ok(result);
            }

        }

        [HttpGet]
        [Route("api/kpi/ReporteTop500/{idStore}/{FechaDesde}/{FechaHasta}")]
        public IHttpActionResult ReporteTop500(int idStore, string FechaDesde, string FechaHasta)
        {
            var result = data.Database.SqlQuery<ReporteTop500>("exec [KPI].[CBR_ReporteTop500]" + idStore + ",'" + FechaDesde + "'" + ",'" + FechaHasta + "'").ToList();

            return Ok(result);
            

            //else
            //{
            //    var result = data.Database.SqlQuery<Top500FaltantesDisponibles>("exec [KPI].[CBR_GetTop300Faltantes_SP]" + idStore);

            //    return Ok(result);
            //}

        }


        [HttpGet]
        [Route("api/kpi/GetDataProductosPasillo/{StoreId}/{IdMedicion}")]
        public IHttpActionResult GetDataProductosPasillo(int StoreId, int IdMedicion)

        {
            if (StoreId == 1 && IdMedicion == 1)
            {
                var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode, 
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =1 and kpi.Top500=1").ToList();
                return Ok(datos);



            }

            if (StoreId == 1 && IdMedicion == 2)
            {
                var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode,                                                                
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =1 and kpi.Top300=1").ToList();
                return Ok(datos);



            }


            if (StoreId == 2 && IdMedicion == 1)
            {
                var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode, 
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =2 and kpi.Top500=1").ToList();
                return Ok(datos);



            }

            if (StoreId == 2 && IdMedicion == 2)
            {
                var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode, 
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =2 and kpi.Top300=1").ToList();
                return Ok(datos);



            }

            if (StoreId == 3 && IdMedicion == 1)
            {
                var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode, 
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =3 and kpi.Top500=1").ToList();
                return Ok(datos);



            }

            if (StoreId == 3 && IdMedicion == 2)
            {
                var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode, 
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =3 and kpi.Top300=1").ToList();
                return Ok(datos);



            }


            if (StoreId == 4 && IdMedicion == 1)
            {
                var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode, 
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =4 and kpi.Top500=1").ToList();
                return Ok(datos);


            }

            if (StoreId == 4 && IdMedicion == 2)
            {
                var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode, 
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =4 and kpi.Top300=1").ToList();
                return Ok(datos);


            }



            else
            {
                {
                    var datos = data.Database.SqlQuery<ProductosPasillo>(@"select kpi.ItemId ItemId, 
                                                                i.Description , 
                                                                i.ItemLookupCode, 
                                                                p.PasilloId  PasilloId
                                                                from KPI.Cbr_Items_Top500 kpi
                                                                left join Item i on kpi.ItemId = i.ID
                                                                left join  KPI.Cbr_Items_Pasillos p 
                                                                on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
                                                                where  kpi.StoreId =3 and kpi.Top500=1").ToList();
                    return Ok(datos);
                }



            }









        }

        [HttpGet]
        [Route("api/kpi/GetDataProductosConPasillo/{StoreId}/{IdConteo}")]
        public IHttpActionResult GetDataProductosConPasillo(int StoreId, int IdConteo)
        {
            if (IdConteo == 1)
            {

                var itemPasillo = (from ItemPasillo in data.Cbr_Items_Pasillos
                                   join i in data.Item on ItemPasillo.ItemId equals i.ID
                                   join p in data.Cbr_Item_Top500_Pasillo on ItemPasillo.PasilloId equals p.id
                                   join It in data.Cbr_Items_Top500 on ItemPasillo.ItemId equals It.ItemId
                                   where ItemPasillo.Tienda == StoreId && It.Top500 == true && It.StoreId == StoreId


                                   select new
                                   {
                                       Description = i.Description,
                                       ItemId = ItemPasillo.ItemId,
                                       Pasillo = p.Pasillo,
                                       ItemLookupCode = i.ItemLookupCode,

                                   }

                        ).ToList();
            
                return Ok(itemPasillo);

            }

            if (IdConteo == 2)
            {

                var itemPasillo = (from ItemPasillo in data.Cbr_Items_Pasillos
                                   join i in data.Item on ItemPasillo.ItemId equals i.ID
                                   join p in data.Cbr_Item_Top500_Pasillo on ItemPasillo.PasilloId equals p.id
                                   join It in data.Cbr_Items_Top500 on ItemPasillo.ItemId equals It.ItemId
                                   where ItemPasillo.Tienda == StoreId && It.Top300 == true && It.StoreId== StoreId     

                                   select new
                                   {
                                       Description = i.Description,
                                       ItemId = ItemPasillo.ItemId,
                                       Pasillo = p.Pasillo,
                                       ItemLookupCode = i.ItemLookupCode,

                                   }

                        ).ToList();

                return Ok(itemPasillo);

            }

            else
            {
                var itemPasillo = (from ItemPasillo in data.Cbr_Items_Pasillos
                                   join i in data.Item on ItemPasillo.ItemId equals i.ID
                                   join p in data.Cbr_Item_Top500_Pasillo on ItemPasillo.PasilloId equals p.id
                                   join It in data.Cbr_Items_Top500 on ItemPasillo.ItemId equals It.ItemId
                                   where ItemPasillo.Tienda == StoreId && It.Top500 == true

                                   select new
                                   {
                                       Description = i.Description,
                                       ItemId = ItemPasillo.ItemId,
                                       Pasillo = p.Pasillo,
                                       ItemLookupCode = i.ItemLookupCode,

                                   }

                     ).ToList();

                return Ok(itemPasillo);

            }





        }


        //[HttpGet]
        //[Route("api/kpi/GetFaltantes")]
        //public IHttpActionResult GetFaltantes_sp()
        //{

        //    var result = data.Database.SqlQuery<Top500>("exec[KPI].[CBR_GetTop500Pendientes_SP]");
        //    return Ok(result);
        //}



        [HttpPost]
        [Route("api/kpi/GetUser")]
        public IHttpActionResult GetUser(Login User)
        {

            var userAll = data.Cbr_UsersKPI.FirstOrDefault(i => i.Usuario == User.User && i.Password == User.Password && i.State==true);
            if (userAll == null)
            {
                return BadRequest("Credenciales Incorrectas");
            }
            else
            {
                userAll.IsLogged = User.IsLogged;
                data.SaveChanges();
                return Ok(userAll);
            }

        }



        [HttpGet]
        [Route("api/kpi/GetUsers/{idStore}")]
        public IHttpActionResult GetUserByStore(int idStore)
        {

            var result = data.Cbr_UsersKPI.Where(i => i.StoreId == idStore).OrderBy(i=>i.State).ToList();

            return Ok(result);
        }


        [HttpPut]
        [Route("api/kpi/PutUser/{userId}")]
        public IHttpActionResult UpdateUser(int userId, Cbr_UsersKPI user)

        {
            var UserUpdate = data.Cbr_UsersKPI.FirstOrDefault(i => i.userID == userId);
            UserUpdate.NombreCompleto = user.NombreCompleto;
            UserUpdate.Usuario = user.Usuario;
            UserUpdate.Rol = user.Rol;
            UserUpdate.StoreId = user.StoreId;
            UserUpdate.State = user.State;





            data.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("api/kpi/DeleteUser/{userId}/{State}")]
        public IHttpActionResult DeleteUser(int userId, bool State)

        {
            var UserUpdate = data.Cbr_UsersKPI.FirstOrDefault(i => i.userID == userId);
            UserUpdate.State = State;
            data.SaveChanges();
            return Ok();
        }




        [HttpPost]
        [Route("api/kpi/createUser")]
        public IHttpActionResult AddUser(Cbr_UsersKPI usuarioNuevo)
        {
            var ValidateExistence = data.Cbr_UsersKPI.FirstOrDefault(i => i.Usuario == usuarioNuevo.Usuario);

            if (ValidateExistence == null)
            {
                data.Cbr_UsersKPI.Add(usuarioNuevo);
            }
            else
            {
                return BadRequest("Usuario repetido");
            }
            data.SaveChanges();
            return Ok();
        }


        [HttpPost]
        [Route("api/kpi/InsertFaltante")]
        public IHttpActionResult AddProductosTop500(Cbr_Faltantes_Top500 nuevoProductoFaltante)
        {


            Cbr_Faltantes_Top500 faltante = new Cbr_Faltantes_Top500();

            faltante.disponible = nuevoProductoFaltante.disponible;
            faltante.ItemId = nuevoProductoFaltante.ItemId;
            faltante.userID = nuevoProductoFaltante.userID;
            faltante.StoreId = nuevoProductoFaltante.StoreId;
            faltante.Top500 = nuevoProductoFaltante.Top500;
            faltante.Top300 = nuevoProductoFaltante.Top300;
            faltante.Fecha = DateTime.Now;

            data.Cbr_Faltantes_Top500.Add(faltante);
            data.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("api/kpi/InsertProductoTop/{StoreId}/{IsTop500}/{IsTop300}")]
        public IHttpActionResult AddProductoTop500(List<string> nuevosProductosTop, int StoreId, bool IsTop500, bool IsTop300)
        {
            //data.Cbr_Items_Top500.RemoveRange(data.Cbr_Items_Top500);

            var ItemTop500 = data.Cbr_Items_Top500.Where(i => i.StoreId == StoreId && i.Top500 == IsTop500 && i.Top300 == IsTop300).ToList();

            if (ItemTop500 == null)
            {
                foreach (string nuevo in nuevosProductosTop)
                {
                    try
                    {
                        var NuevoTopItem = data.Item.FirstOrDefault(i => i.ItemLookupCode == nuevo).ID;


                        Cbr_Items_Top500 itemID = new Cbr_Items_Top500();
                        itemID.ItemId = NuevoTopItem;
                        itemID.StoreId = StoreId;
                        itemID.Top500 = IsTop500;
                        itemID.Top300 = IsTop300;
                        data.Cbr_Items_Top500.Add(itemID);

                    }
                    catch
                    {
                        return BadRequest("El codigo" + " " + nuevo + " " + "no existe, por favor verifiquelo y vuelva a cargar la lista");
                    }
                }

            }

            else
            {
                data.Cbr_Items_Top500.RemoveRange(ItemTop500);

                //data.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Cbr_Items_Top500', RESEED, 0)");

                foreach (string nuevo in nuevosProductosTop)
                {
                    try
                    {
                        var NuevoTopItem = data.Item.FirstOrDefault(i => i.ItemLookupCode == nuevo).ID;
                        ;

                        Cbr_Items_Top500 itemID = new Cbr_Items_Top500();
                        itemID.ItemId = NuevoTopItem;
                        itemID.StoreId = StoreId;
                        itemID.Top500 = IsTop500;
                        itemID.Top300 = IsTop300;
                        data.Cbr_Items_Top500.Add(itemID);

                    }
                    catch
                    {
                        return BadRequest("El codigo" + " " + nuevo + " " + "no existe, por favor verifiquelo y vuelva a cargar la lista");
                    }
                }

            }





            data.SaveChanges();

            return Ok();


        }




        [HttpPost]
        [Route("api/kpi/PostPasillo/{ItemId}/{IdPasillo}/{IdStore}")]
        public IHttpActionResult AsignarPasillo(int ItemId, int IdPasillo, int IdStore)

        {

            Cbr_Items_Pasillos pasillo = new Cbr_Items_Pasillos();
            pasillo.PasilloId = IdPasillo;
            pasillo.ItemId = ItemId;
            pasillo.Tienda = IdStore;
            data.Cbr_Items_Pasillos.Add(pasillo);
            data.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("api/kpi/PutPasillo/{ItemId}/{IdPasillo}/{IdStore}")]
        public IHttpActionResult UpdatePasillo(int ItemId, int IdPasillo, int IdStore)

        {
            var PorductoPasillo = data.Cbr_Items_Pasillos.FirstOrDefault(i => i.ItemId == ItemId && i.Tienda == IdStore);
            PorductoPasillo.PasilloId = IdPasillo;


            data.SaveChanges();
            return Ok();
        }




        [HttpGet]
        [Route("api/kpi/GetProductosPasillo")]
        public IHttpActionResult GetProductosFaltantes()
        {


            var result = data.Database.SqlQuery<PasilloProductoModel>(@"select * from kpi.Cbr_Item_Top500_Pasillo");
            return Ok(result);


        }


        [HttpDelete]
        [Route("api/kpi/DeleteFaltante/{id}")]
        public IHttpActionResult DeleteFaltante(int id)

        {
            Cbr_Faltantes_Top500 faltante = data.Cbr_Faltantes_Top500.Find(id);

            data.Cbr_Faltantes_Top500.Remove(faltante);

            data.SaveChanges();
            return Ok(faltante);
        }



        [HttpGet]
        [Route("api/kpi/GetProductosTop")]
        public IHttpActionResult GetProductosTop()
        {

            //var itemtop = data.Cbr_Items_Top500.Join(data.Item,

            //     cbritem => cbritem.ItemId,
            //     item => item.ID,


            //    (cbritem, item) => new { 

            //        item.Description,
            //        item.ItemLookupCode,
            //        cbritem.ItemId

            //    }
            //    ).ToList();

            var itemTop = (from topItem in data.Cbr_Items_Top500
                           join i in data.Item on topItem.ItemId equals i.ID
                           join f in data.Cbr_Faltantes_Top500 on topItem.ItemId equals f.ItemId into faltan
                           from FaltaProducto in faltan.DefaultIfEmpty()

                           select new
                           {
                               ItemID = topItem.ItemId,
                               Description = i.Description,
                               ItemLookupCode = i.ItemLookupCode,

                               disponible = FaltaProducto.disponible
                           }

                          ).ToList();


            return Ok(itemTop);

        }




        [HttpPut]
        [Route("api/kpi/PutDisponible/{id}")]
        public IHttpActionResult ActualizarEstado(int id, Cbr_Faltantes_Top500 disponible)

        {

            var Disponible = data.Cbr_Faltantes_Top500.FirstOrDefault(i => i.ItemId == disponible.ItemId && i.id == disponible.id);
            Disponible.disponible = disponible.disponible;


            data.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("api/kpi/PutLogin/{id}")]
        public IHttpActionResult ActualizarLogin(int id, Cbr_UsersKPI userLogged)

        {

            var userKPI = data.Cbr_UsersKPI.FirstOrDefault(i => i.userID == id);
            userKPI.IsLogged = userLogged.IsLogged;


            data.SaveChanges();
            return Ok();
        }

    }





}