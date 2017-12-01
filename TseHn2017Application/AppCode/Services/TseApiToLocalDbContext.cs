using Mapster;
using System;
using System.Collections.Generic;
using TseHn2017Application.AppCode.Context;
using TseHn2017Application.AppCode.Engines;
using TseHn2017Application.Dto;

namespace TseHn2017Application.AppCode.Services
{
    public class TseApiToLocalDbContext
    {
        private readonly TseActasPresidenteDbContext _context;
        public int ActasGuardadas { get; set; }
        public TseApiToLocalDbContext(TseActasPresidenteDbContext context)
        {
            _context = context;
            ActasGuardadas = 1;
        }
        public async void InsertTseApiToLocalDataBase(int index)
        {
            try
            {
                var totalActas = new List<Acta>();
                var totalVotos = new List<Voto>();

                for (int i = index; i <= 18128; i++)
                {
                    var actaDto = GetActaFromApi(i);

                    if (actaDto == null)
                    {
                        actaDto = new ActaDto { CodActa = i, Votos = new List<VotoDto>(), CodEstado = 99, NomEstado = "Null Error Api" };
                    }

                    var actaEntity = Factory.CreateActaEntity(actaDto);
                    var votosEntity = Factory.CreateVotoPresidenteEntity(actaDto);
                    totalActas.Add(actaEntity);
                    totalVotos.AddRange(votosEntity);

                    if (i % 25 == 0)
                    {
                        ActasGuardadas = i+1;
                        _context.Actas.AddRange(totalActas);
                        _context.Votoes.AddRange(totalVotos);
                        await _context.SaveChangesAsync();
                        totalActas = new List<Acta>();
                        totalVotos = new List<Voto>();
                        return;
                    }

                    if (i == 18128)
                    {
                        ActasGuardadas = i+1;
                        _context.Actas.AddRange(totalActas);
                        _context.Votoes.AddRange(totalVotos);
                        await _context.SaveChangesAsync();
                        totalActas = new List<Acta>();
                        totalVotos = new List<Voto>();
                        return;
                    }
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        #region Engine
        private ActaDto GetActaFromApi(int actaNumero)
        {
            var engine = new FueraJohApiEngine("https://api.tse.hn");
            var acta = engine.GetActa(actaNumero);
            return acta;
        }
        #endregion

        #region Factory
        public class Factory
        {
            public static Acta CreateActaEntity(ActaDto acta)
            {
                var res = acta.Adapt<Acta>();
                return res;
            }

            public static List<Voto> CreateVotoPresidenteEntity(ActaDto acta)
            {
                var res = acta.Votos.Adapt<List<Voto>>();
                foreach (var item in res)
                {
                    item.CodActa = acta.CodActa;
                }
                return res;
            }
        }
        #endregion
    }
}
