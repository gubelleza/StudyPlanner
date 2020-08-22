using System;

#nullable enable
namespace AgendaEstudos.Models {
    public class Prioridades : IEquatable<Prioridades> {
        private static readonly double TOLERANCE = 0.01;
        
        public string Name { get; }
        public double Value { get; }
        public string CssClass { get; }
        
        public static readonly Prioridades Minima = 
            new Prioridades(1, "Minima", "text-success");
        
        public static readonly Prioridades Baixa = 
            new Prioridades(1.5, "Baixa", "text-info");
        
        public static readonly Prioridades Normal = 
            new Prioridades(2.0, "Normal", "text-dark");
        
        public static readonly Prioridades Alta = 
            new Prioridades(2.5, "Alta", "text-warning");
        
        public static readonly Prioridades Maxima = 
            new Prioridades(3.0, "Maxima", "text-danger");

        public Prioridades(double value, string name, string cssClass) {
            Value = value;
            Name = name;
            CssClass = cssClass;
        }

        public static Prioridades FromVal(double val) {
            Console.WriteLine(">>> " + val);
            if (val.Equals(Minima.Value)) return Minima;
            if (Math.Abs(val - Baixa.Value) < TOLERANCE) return Baixa;
            if (Math.Abs(val - Normal.Value) < TOLERANCE) return Normal;
            if (Math.Abs(val - Alta.Value) < TOLERANCE) return Alta;
            if (Math.Abs(val - Maxima.Value) < TOLERANCE) return Maxima;

            return Normal;
        }
        
        public override bool Equals(object? obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Prioridades)) return false;
            return Equals((Prioridades) obj);
        }

        public bool Equals(Prioridades? other) {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name == other.Name && (Math.Abs(Value - other.Value) < TOLERANCE);
        }
        
        public bool Equals(double other) {
            return (Math.Abs(Value - other) < TOLERANCE);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Name, Value);
        }

        public static bool operator ==(Prioridades? left, Prioridades? right) {
            return Equals(left, right);
        }

        public static bool operator !=(Prioridades? left, Prioridades? right) {
            return !Equals(left, right);
        }
    }
}