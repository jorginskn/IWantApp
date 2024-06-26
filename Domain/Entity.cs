﻿using IWantApp.Domain.Products;

namespace IWantApp.Domain;

public class Entity
{
    public Entity()
    {
        Id= Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
     public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedOn { get; set; }

 }
