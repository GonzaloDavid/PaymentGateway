using System;
using AutoMapper;
using ExperTeamTest.Entities;
using ExperTeamTest.Models;

namespace ExperTeamTest.Mapper
{
	public class InvoiceMapper : Profile
    {
		public InvoiceMapper() 
		{
            CreateMap<InvoiceDto, Invoice>();
        }
	}
}

