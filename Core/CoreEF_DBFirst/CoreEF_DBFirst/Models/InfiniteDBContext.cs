using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class InfiniteDBContext : DbContext
    {
        public InfiniteDBContext()
        {
        }

        public InfiniteDBContext(DbContextOptions<InfiniteDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Casetable> Casetables { get; set; }
        public virtual DbSet<Dummy1> Dummy1s { get; set; }
        public virtual DbSet<Dummy2> Dummy2s { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Employeedummy> Employeedummies { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public virtual DbSet<Indexsample> Indexsamples { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSale> ProductSales { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<Table2> Table2s { get; set; }
        public virtual DbSet<TblAudit> TblAudits { get; set; }
        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<Tbldummy> Tbldummies { get; set; }
        public virtual DbSet<Tblsample1> Tblsample1s { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<VwEmpdatum> VwEmpdata { get; set; }
        public virtual DbSet<Vwmyview> Vwmyviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=Laptop-tjj7d977;Database=InfiniteDB;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Casetable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("casetable");

                entity.HasIndex(e => e.Cid, "idx1")
                    .IsClustered();

                entity.Property(e => e.Casename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("casename");

                entity.Property(e => e.Cid).HasColumnName("cid");
            });

            modelBuilder.Entity<Dummy1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dummy1");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Dummy2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dummy2");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.ToTable("Emp");

                entity.HasIndex(e => e.Phone, "Uc_phone")
                    .IsUnique();

                entity.HasIndex(e => e.EmpName, "idxname");

                entity.HasIndex(e => e.Phone, "ixphone")
                    .HasFilter("([phone] IS NOT NULL)");

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employeedummy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employeedummy");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ExceptionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExceptionLog");

                entity.Property(e => e.ExMessage).HasColumnName("exMessage");

                entity.Property(e => e.ExSource).HasColumnName("exSource");

                entity.Property(e => e.ExType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("exType");

                entity.Property(e => e.ExUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("exUrl");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("logDate");

                entity.Property(e => e.Logid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Indexsample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("indexsample");

                entity.HasIndex(e => e.City, "idxcity");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Sage).HasColumnName("sage");

                entity.Property(e => e.Sampleid).HasColumnName("sampleid");

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClassSubject)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("class_subject");

                entity.Property(e => e.Marks).HasColumnName("marks");

                entity.Property(e => e.Stdname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stdname");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.ProductName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductSale>(entity =>
            {
                entity.HasKey(e => e.ProductSalesId)
                    .HasName("PK__ProductS__1B97309E893590EE");

                entity.Property(e => e.ProductSalesId).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSales)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductSa__Produ__5CD6CB2B");
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table1");

                entity.Property(e => e.Tgrade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TGrade")
                    .IsFixedLength(true);

                entity.Property(e => e.Tid).ValueGeneratedOnAdd();

                entity.Property(e => e.Tname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tpercentage).HasColumnName("TPercentage");
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table2");

                entity.Property(e => e.Tgrade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TGrade")
                    .IsFixedLength(true);

                entity.Property(e => e.Tid).ValueGeneratedOnAdd();

                entity.Property(e => e.Tname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tpercentage).HasColumnName("TPercentage");
            });

            modelBuilder.Entity<TblAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAudit");

                entity.Property(e => e.Details).HasColumnName("details");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__tblDepar__014881AEFADA5AB6");

                entity.ToTable("tblDepartment");

                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.Property(e => e.Deptname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__tblEmplo__C190170BA9F4F080");

                entity.ToTable("tblEmployee");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("EID");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__tblEmploy__DeptI__30F848ED");
            });

            modelBuilder.Entity<Tbldummy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbldummy");

                entity.Property(e => e.Did)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dname");
            });

            modelBuilder.Entity<Tblsample1>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__tblsampl__DDDFDD36B0821805");

                entity.ToTable("tblsample1");

                entity.HasIndex(e => e.Sphone, "UQ__tblsampl__860AEE5A73381F25")
                    .IsUnique();

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("sid");

                entity.Property(e => e.Sage).HasColumnName("sage");

                entity.Property(e => e.Scity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("scity")
                    .HasDefaultValueSql("('Chennai')");

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("sname");

                entity.Property(e => e.Sphone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sphone");
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testTable");

                entity.Property(e => e.Age).HasComputedColumnSql("(datediff(year,[dob],getdate()))", false);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Tname).IsUnicode(false);
            });

            modelBuilder.Entity<VwEmpdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpdata");

                entity.Property(e => e.Deptname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptname");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("gender")
                    .IsFixedLength(true);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Vwmyview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwmyview");

                entity.Property(e => e.Deptname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptname");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
