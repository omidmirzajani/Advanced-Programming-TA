package A4;

public class App {

    public enum Config {
        Graphic(1),
        Ram(2),
        Cpu(4);
        
        public int ConfigValue;
        int Value;
        
        private Config(int configValue) {
            this.ConfigValue = configValue;
        }

        public void ChangeValue(int v){
            this.Value=v;
        }
    }

    public static String ChooseBest(Config c){
        boolean f1=((c.Value & Config.Graphic.ConfigValue)==Config.Graphic.ConfigValue);
        boolean f2=((c.Value & Config.Ram.ConfigValue)==Config.Ram.ConfigValue);
        boolean f3=((c.Value & Config.Cpu.ConfigValue)==Config.Cpu.ConfigValue);
        
        if(f1 && f2 && f3)
            return "Excellent";
        if(f2 && (f1 || f3))
            return "Very Good";
        if(f2 && !(f1 || f3))
            return "Good";
        return "Not Bad";
        
    }

    

    public static void main(String[] args) {
        
    }
}
