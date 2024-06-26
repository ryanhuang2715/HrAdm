﻿using System;
using System.Collections.Generic;
using Base.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HrAdm.Tables
{
    public partial class MyContext : DbContext
    {
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cms> Cms { get; set; } = null!;
        public virtual DbSet<CustInput> CustInput { get; set; } = null!;
        public virtual DbSet<Dept> Dept { get; set; } = null!;
        public virtual DbSet<Leave> Leave { get; set; } = null!;
        public virtual DbSet<User> User { get; set; } = null!;
        public virtual DbSet<UserJob> UserJob { get; set; } = null!;
        public virtual DbSet<UserLang> UserLang { get; set; } = null!;
        public virtual DbSet<UserLicense> UserLicense { get; set; } = null!;
        public virtual DbSet<UserSchool> UserSchool { get; set; } = null!;
        public virtual DbSet<UserSkill> UserSkill { get; set; } = null!;
        public virtual DbSet<XpCode> XpCode { get; set; } = null!;
        public virtual DbSet<XpEasyRpt> XpEasyRpt { get; set; } = null!;
        public virtual DbSet<XpFlow> XpFlow { get; set; } = null!;
        public virtual DbSet<XpFlowLine> XpFlowLine { get; set; } = null!;
        public virtual DbSet<XpFlowNode> XpFlowNode { get; set; } = null!;
        public virtual DbSet<XpFlowSign> XpFlowSign { get; set; } = null!;
        public virtual DbSet<XpFlowSignTest> XpFlowSignTest { get; set; } = null!;
        public virtual DbSet<XpFlowTest> XpFlowTest { get; set; } = null!;
        public virtual DbSet<XpImportLog> XpImportLog { get; set; } = null!;
        public virtual DbSet<XpProg> XpProg { get; set; } = null!;
        public virtual DbSet<XpRole> XpRole { get; set; } = null!;
        public virtual DbSet<XpRoleProg> XpRoleProg { get; set; } = null!;
        public virtual DbSet<XpTranLog> XpTranLog { get; set; } = null!;
        public virtual DbSet<XpUserRole> XpUserRole { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_Fun.Config.Db);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cms>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "Cms_Id")
                    .IsUnique();

                entity.Property(e => e.CmsType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.Revised).HasColumnType("datetime");

                entity.Property(e => e.Reviser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<CustInput>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "CustInput_Id")
                    .IsUnique();

                entity.Property(e => e.FldColor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FldDate).HasColumnType("date");

                entity.Property(e => e.FldDt).HasColumnType("datetime");

                entity.Property(e => e.FldFile).HasMaxLength(100);

                entity.Property(e => e.FldSelect)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FldText).HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "Dept_Id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MgrId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<Leave>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "Leave_Id")
                    .IsUnique();

                entity.Property(e => e.AgentId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.FlowStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hours).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Revised).HasColumnType("datetime");

                entity.Property(e => e.Reviser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "User_Id")
                    .IsUnique();

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeptId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.PhotoFile).HasMaxLength(100);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserJob>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "UserJob_Id")
                    .IsUnique();

                entity.Property(e => e.CorpName).HasMaxLength(30);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobDesc).IsUnicode(false);

                entity.Property(e => e.JobName).HasMaxLength(30);

                entity.Property(e => e.JobPlace).HasMaxLength(30);

                entity.Property(e => e.JobType).HasMaxLength(30);

                entity.Property(e => e.StartEnd)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLang>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "UserLang_Id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LangName).HasMaxLength(30);

                entity.Property(e => e.ListenLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReadLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpeakLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WriteLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserLicense>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "UserLicense_Id")
                    .IsUnique();

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseName).HasMaxLength(30);

                entity.Property(e => e.StartEnd)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserSchool>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "UserSchool_Id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolDept).HasMaxLength(20);

                entity.Property(e => e.SchoolName).HasMaxLength(30);

                entity.Property(e => e.SchoolType).HasMaxLength(20);

                entity.Property(e => e.StartEnd)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "UserSkill_Id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SkillDesc).HasMaxLength(500);

                entity.Property(e => e.SkillName).HasMaxLength(30);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpCode>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Value });

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name_enUS).HasMaxLength(30);

                entity.Property(e => e.Name_zhCN).HasMaxLength(30);

                entity.Property(e => e.Name_zhTW).HasMaxLength(30);

                entity.Property(e => e.Note).HasMaxLength(255);
            });

            modelBuilder.Entity<XpEasyRpt>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "XpEasyRpt_Id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sql).HasMaxLength(500);

                entity.Property(e => e.ToEmails)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TplFile).HasMaxLength(100);
            });

            modelBuilder.Entity<XpFlow>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_Flow");

                entity.HasIndex(e => e.Id, "XpFlow_Id")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<XpFlowLine>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_FlowLine");

                entity.HasIndex(e => e.Id, "XpFlowLine_Id")
                    .IsUnique();

                entity.Property(e => e.CondStr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndNode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlowId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartNode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpFlowNode>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_FlowNode");

                entity.HasIndex(e => e.Id, "XpFlowNode_Id")
                    .IsUnique();

                entity.Property(e => e.FlowId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.NodeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PassType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SignerType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SignerValue)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpFlowSign>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_FlowSign");

                entity.HasIndex(e => e.Id, "XpFlowSign_Id")
                    .IsUnique();

                entity.Property(e => e.FlowId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NodeName).HasMaxLength(30);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.SignStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SignTime).HasColumnType("datetime");

                entity.Property(e => e.SignerId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignerName).HasMaxLength(20);

                entity.Property(e => e.SourceId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpFlowSignTest>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "XpFlowSignTest_Id")
                    .IsUnique();

                entity.Property(e => e.FlowId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NodeName).HasMaxLength(30);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.SignStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SignTime).HasColumnType("datetime");

                entity.Property(e => e.SignerId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignerName).HasMaxLength(20);

                entity.Property(e => e.SourceId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpFlowTest>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "XpFlowTest_Id")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.FlowStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InputJson)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpImportLog>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.HasIndex(e => e.Id, "XpImportLog_Id")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatorName).HasMaxLength(30);

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpProg>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_Prog");

                entity.HasIndex(e => e.Id, "XpProg_Id")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpRole>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_Role");

                entity.HasIndex(e => e.Id, "XpRole_Id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<XpRoleProg>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_RoleProg");

                entity.HasIndex(e => e.Id, "XpRoleProg_Id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProgId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpTranLog>(entity =>
            {
                entity.HasKey(e => e.Sn);

                entity.Property(e => e.Act)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ColName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.NewValue).HasMaxLength(500);

                entity.Property(e => e.OldValue).HasMaxLength(500);

                entity.Property(e => e.RowId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XpUserRole>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_UserRole");

                entity.HasIndex(e => e.Id, "XpUserRole_Id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
