using System;
using AutoMapper;
using ExperTeamTest.Entities;
using ExperTeamTest.Models;

namespace ExperTeamTest.Mapper
{
	public class PagoMapper : Profile
    {
		public PagoMapper()
		{
            CreateMap<PagoDto, Pago>();
        }
	}
}

