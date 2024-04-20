using FitBook.Models;
using Microsoft.EntityFrameworkCore;

namespace FitBook.Data;

public class ApiDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<WorkoutExercise> WorkoutExercises { get; set; }

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Workout>(entity =>
        {
            entity.HasOne(u => u.User)
                .WithMany(u => u.Workouts)
                .HasForeignKey(x => x.WorkoutID)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Workout>(entity =>
        {
            entity.HasMany(w => w.Exercises)
                .WithMany(e => e.Workouts)
                .UsingEntity<WorkoutExercise>(
                    w => w.HasOne<Exercise>().WithMany().HasForeignKey(e => e.ExerciseID),
                    e => e.HasOne<Workout>().WithMany().HasForeignKey(w => w.WorkoutID));
        });

        modelBuilder.Entity<Exercise>().HasKey(e => e.ExerciseID);
        modelBuilder.Entity<Workout>().HasKey(e => e.WorkoutID);
        modelBuilder.Entity<User>().HasKey(e => e.UserID);
        modelBuilder.Entity<WorkoutExercise>().HasKey(e => e.WorkoutExerciseID);
    }
}