﻿using GRC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the Interface
//Ceci est une Fluent API
namespace GRC.Domain.Configuration;

public class OrganisationConfiguration : IEntityTypeConfiguration<Organisation>
{
    public void Configure(EntityTypeBuilder<Organisation> builder)
    {
        builder
            .Property(o => o.Nom)
            .IsRequired();
        builder
            .Property(o => o.OrganisationId) 
            .IsRequired();
        builder
            .HasKey(o => o.OrganisationId);
        
    }
}
