using ClassLibrar.Data;

Context _context = new Context();

if (!_context.Jatekos.Any()) {
    var sorok = File.ReadAllLines(@"c:\adat\nevek.csv").Skip(1);
    foreach (var line in sorok)    
        _context.Jatekos.Add(new ClassLibrar.Models.Jatekos(line));
    _context.SaveChanges();
}

if (!_context.Tipp.Any()) {
    var sorok = File.ReadAllLines(@"c:\adat\l5.csv").Skip(1);
    foreach (var line in sorok)    
        _context.Tipp.Add(new ClassLibrar.Models.Tipp(line));
    _context.SaveChanges();
}