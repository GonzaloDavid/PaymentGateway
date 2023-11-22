using System;
using AutoMapper;
using PaymentGateway.Modelos;

namespace PaymentGateway.Mappers
{
	public class TransactionAutoMapper : Profile
    {
		public TransactionAutoMapper()
		{
            CreateMap<TransactionDto, TransactionModel>();
        }
    }
}

