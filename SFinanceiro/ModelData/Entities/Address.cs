﻿using System.ComponentModel.DataAnnotations;

namespace SFinanceiro.ModelData.Entities
{
    public class Address
    {
        public required string Id { get; set; }

        public required string CEP { get; set; }

        public required string City { get; set; }

        public required string State { get; set; }

        public required bool Status { get; set; }

        [StringLength(50)]
        public string UserIncluded { get; set; }

        public required DateTime DateIncluded { get; set; }

        [StringLength(50)]
        public string UserChange { get; set; }

        public DateTime? DateChange { get; set; }

        public ICollection<Collaborator> Collaborators { get; set; }

        public Address()
        {

        }

        public Address(string cEP, string city, string state)
        {
            CEP = cEP;
            City = city;
            State = state;
        }
    }
}