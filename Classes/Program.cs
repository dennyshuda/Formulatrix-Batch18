Panda p = new("Bahlil");
Panda p2 = new("Wowo");

p.DisplayInfo();

Console.WriteLine("panda mate " + p.Mate?.Name);

p.MeetPanda(p);

p.SetMate(p2);

p.Cry();

Console.WriteLine(Panda.GetSpeciesInfo(p));

p.DisplayInfo();

