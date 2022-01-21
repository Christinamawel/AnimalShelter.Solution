using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "George", Species = "Cat", Breed = "Main Coon", Age = 7, Gender = "Male", AvailableForAdoption = true },
          new Animal { AnimalId = 2, Name = "Lilly", Species = "Cat", Breed = "Domestic short hair", Age = 12, Gender = "Female", AvailableForAdoption = true },
          new Animal { AnimalId = 3, Name = "Rover", Species = "Dog", Breed = "Labrador Retriever", Age = 1, Gender = "Male", AvailableForAdoption = true },
          new Animal { AnimalId = 4, Name = "Fido", Species = "Dog", Breed = "Dachshund", Age = 4, Gender = "Male", AvailableForAdoption = true },
          new Animal { AnimalId = 5, Name = "Gerald", Species = "Hamster", Breed = "Syrian", Age = 2, Gender = "Male", AvailableForAdoption = true }
        );
    }
  }
}