using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mantenimientoStandares.Entidades;
using mantenimientoStandares.AccesoaDatos;

namespace mantenimientoStandares.LogicadeNegocio
{
    public class GestordeMantenimiento
    {
        public void Insertar(Standar standar)
        {
            try
                {
                    StandarAD standarAD = new StandarAD();
                    int idstandar = standarAD.Insertar(standar);
                }
            catch (Exception e)
                {
            throw e;
                }
        }

        public void Actualizar(Standar standar)
        {
            try
            {
                StandarAD standarAD = new StandarAD();
                int idstandar = standarAD.Actualizar(standar);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<Area> ListarAreas()
        {
            List<Area> areas = new List<Area>();
            try
            {
                AreaAD areaAD = new AreaAD();
                areas = areaAD.Listar();
            }
            catch (Exception e)
            {
                throw e;
            }

            return areas;
        }

        public static List<Formato> ListarFormatos()
        {
            List<Formato> formatos = new List<Formato>();
            try
            {
                FormatoAD formatoAD = new FormatoAD();
                formatos = formatoAD.Listar();
            }
            catch (Exception e)
            {
                throw e;
            }
            return formatos;
        }

        public static List<Estandares> ListarStandares()
        {
            List<Estandares> standars = new List<Estandares>();
            try
            {
                EstandarAD standarAD = new EstandarAD();
                standars = standarAD.Listar();
            }
            catch (Exception e)
            {
                throw e;
            }
            return standars;
        }

        public static List<Jornal> ListarJornalTop()
        {
            List<Jornal> jornales = new List<Jornal>();
            try
            {
                JornalBaseAD jornalBaseAD = new JornalBaseAD();
                jornales = jornalBaseAD.ListarJornalTop();
            }
            catch (Exception e)
            {
                throw e;
            }
            return jornales;
        }

        public static List<Standar> Verificar_duplicidad_Estandar(string IdArea, DateTime FechaInicio)
        {
            List<Standar> standares = new List<Standar>();
            try
            {
                StandarAD standarAD = new StandarAD();
                standares = standarAD.Verificar_duplicidad_Estandar(IdArea, FechaInicio);
            }
            catch (Exception e)
            {
                throw e;
            }
            return standares;
        }


        public static List<Estandares> LimpiarEstandares()
        {
            List<Estandares> standars = new List<Estandares>();
            try
            {
                EstandarAD standarAD = new EstandarAD();
                standars = standarAD.LimpiarEstandares();
            }
            catch (Exception e)
            {
                throw e;
            }
            return standars;
        }
    }
}
