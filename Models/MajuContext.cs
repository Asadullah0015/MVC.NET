﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Asad.Models;

public partial class MajuContext : DbContext
{
    public MajuContext()
    {
    }

    public MajuContext(DbContextOptions<MajuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student2> Student2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QGL1RP8\\SQLEXPRESS;Database=MAJU;Trusted_Connection=True;trustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student2__3214EC27230FD741");

            entity.ToTable("Student2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Semester)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
