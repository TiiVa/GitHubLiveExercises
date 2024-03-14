﻿namespace GitHubLiveExercises.Common.Interfaces;

public class Person
{
    public int  Id { get; set; }
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public ICollection<Animal> Pets { get; set; }
}