namespace AgendaEstudos.Models {
    public enum Prioridade {
        Minima = -2, 
        Baixa, 
        Normal, 
        Alta, 
        Maxima 
    }

    public class NivelPrioridade {
            
        public static Prioridade FromValue(int valPrioridade) {
            switch (valPrioridade) {
                case -2:
                    return Prioridade.Minima;
                case -1:
                    return Prioridade.Baixa;
                case 0:
                    return Prioridade.Normal;
                case 1:
                    return Prioridade.Alta;
                case 2:
                    return Prioridade.Maxima;
                default:
                    return Prioridade.Normal;
            }
        }

        public static string CssClass(int valPrioridade) {
            switch (valPrioridade) {
                case -2:
                    return "text-success";
                case -1:
                    return "text-info";
                case 0:
                    return "text-dark";
                case 1:
                    return "text-warning";
                case 2:
                    return "text-danger";
                default:
                    return "text-dark";
            }
        }
    }
}