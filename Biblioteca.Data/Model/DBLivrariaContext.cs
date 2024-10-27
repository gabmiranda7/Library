using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Biblioteca.Data.Model;

public partial class DBLivrariaContext : DbContext
{
    public DBLivrariaContext()
    {
    }

    public DBLivrariaContext(DbContextOptions<DBLivrariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<Configuracao> Configuracaos { get; set; }

    public virtual DbSet<Editora> Editoras { get; set; }

    public virtual DbSet<Emprestimo> Emprestimos { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Idioma> Idiomas { get; set; }

    public virtual DbSet<Livro> Livros { get; set; }

    public virtual DbSet<LivroEmprestado> LivroEmprestados { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=GABRIEL\\sqlexpress;Database=Livraria;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Autor__3213E83F59E8764C");

            entity.ToTable("Autor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Configuracao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Configur__3213E83FD4D282CC");

            entity.ToTable("Configuracao");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Editora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Editora__3213E83F27A96968");

            entity.ToTable("Editora");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Emprestimo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empresti__3213E83F249FD948");

            entity.ToTable("Emprestimo");

            entity.HasIndex(e => e.IdPessoa, "Emprestimo_FKIndex1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPessoa).HasColumnName("idPessoa");

            entity.HasOne(d => d.IdPessoaNavigation).WithMany(p => p.Emprestimos)
                .HasForeignKey(d => d.IdPessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Emprestim__idPes__4316F928");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Genero__3213E83FAC684602");

            entity.ToTable("Genero");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Idioma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Idioma__3213E83F6E41A793");

            entity.ToTable("Idioma");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Livro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Livro__3213E83FB3F585B2");

            entity.ToTable("Livro");

            entity.HasIndex(e => e.IdGenero, "Livro_FKIndex1");

            entity.HasIndex(e => e.IdEditora, "Livro_FKIndex2");

            entity.HasIndex(e => e.IdIdioma, "Livro_FKIndex3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IdEditora).HasColumnName("idEditora");
            entity.Property(e => e.IdGenero).HasColumnName("idGenero");
            entity.Property(e => e.IdIdioma).HasColumnName("idIdioma");
            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEditoraNavigation).WithMany(p => p.Livros)
                .HasForeignKey(d => d.IdEditora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Livro__idEditora__46E78A0C");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Livros)
                .HasForeignKey(d => d.IdGenero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Livro__idGenero__45F365D3");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.Livros)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Livro__idIdioma__47DBAE45");

            entity.HasMany(d => d.IdAutors).WithMany(p => p.IdLivros)
                .UsingEntity<Dictionary<string, object>>(
                    "AutorLivro",
                    r => r.HasOne<Autor>().WithMany()
                        .HasForeignKey("IdAutor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AutorLivr__idAut__4F7CD00D"),
                    l => l.HasOne<Livro>().WithMany()
                        .HasForeignKey("IdLivro")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AutorLivr__idLiv__4E88ABD4"),
                    j =>
                    {
                        j.HasKey("IdLivro", "IdAutor").HasName("PK__AutorLiv__DA6BC4D15AFF3449");
                        j.ToTable("AutorLivro");
                        j.HasIndex(new[] { "IdLivro" }, "Livro_has_Autor_FKIndex1");
                        j.HasIndex(new[] { "IdAutor" }, "Livro_has_Autor_FKIndex2");
                        j.IndexerProperty<int>("IdLivro").HasColumnName("idLivro");
                        j.IndexerProperty<int>("IdAutor").HasColumnName("idAutor");
                    });
        });

        modelBuilder.Entity<LivroEmprestado>(entity =>
        {
            entity.HasKey(e => new { e.IdLivro, e.IdEmprestimo }).HasName("PK__LivroEmp__77718E51FB23CF31");

            entity.ToTable("LivroEmprestado");

            entity.HasIndex(e => e.IdLivro, "Livro_has_Emprestimo_FKIndex1");

            entity.HasIndex(e => e.IdEmprestimo, "Livro_has_Emprestimo_FKIndex2");

            entity.Property(e => e.IdLivro).HasColumnName("idLivro");
            entity.Property(e => e.IdEmprestimo).HasColumnName("idEmprestimo");

            entity.HasOne(d => d.IdEmprestimoNavigation).WithMany(p => p.LivroEmprestados)
                .HasForeignKey(d => d.IdEmprestimo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LivroEmpr__idEmp__4BAC3F29");

            entity.HasOne(d => d.IdLivroNavigation).WithMany(p => p.LivroEmprestados)
                .HasForeignKey(d => d.IdLivro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LivroEmpr__idLiv__4AB81AF0");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pessoa__3213E83F38B5F386");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
