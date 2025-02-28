public partial class ExempleTimer : Form
{
    public ExempleTimer()
    {
        InitializeComponent();
    }
    
    // Executat al carregar el formulari.
    private void onFormLoad(object sender, EventArgs e)
    {
        this.Temporitzador.Interval = 1000; // Estableix el temps (ms) que ha de passar per executar funcions. (En aquest cas, cada 1 segon)
        this.Temporitzador.Start(); // Comença el temporitzador.
    }

    // Executat pel temporitzador.
    private void intervalTick(object sender, EventArgs e)
    {
        this.Temps.Text = DateTime.Now.ToString("HH:mm:ss"); // Mostra el temps actual (HH:MM:SS) i es va actualitzant a cada execució.

        // Si el temps és 10:30:20, el temporitzador es para.
        if (this.Temps.Text == "10:30:20")
        {
            this.Temporitzador.Stop(); // Para el temporitzador.
            this.Temps.Text = "2̶͇͚̮̙̙̼̯̖̘̟̦̽̃͋͂̿͛̊͊̄̆͒͊͘͜͠ͅ2̶̛̞̜̈́2̴̧̧͈̜͍̟̠̾̾̅̔̔͊̐̀̈͑̃̈́̆̕ͅ2̸̡̡̙̟̜͍̫̮̱͖̜͕̿̃̄̌̈́͒̀̽̇̒͗2̴̨͔̙̮̗͍̝̆͐́̃̏͊̑́̊͌2̷̢̯̗̮͉̦̺͙̣̹͉͉̖͒̇̋͜2̸͚͚͍̺̯̘̫͚͊̿̂̃͗̂͑̕̕͜͠2̴̣̒̃̈́͗̐̓̐2̴̧̡̤͉̟̗̼͓̱̓̀̔̓̏͛̒̇̾̾̆͆̀̋͐2̸̻̦̘̘͚̺̦̾́͌̾̃͊ͅͅ2̸̢͎̙̫̤̝͉̖͉̮̤̼̈́̂͜ͅͅ2̷̙̗̐́̀͑̂̒͋̂̈̈́̑͝͠͝2̷̢̧̯̼͕͎̼̘͉̣͗͗́͒̃̈́̓̔̃̒́̚̚̚͝ͅ2̷̡̧̠̫̗̲̬̤̺͐͌́̄͑2̶̡̨̟͚̠̩̳͉̩̮͈̭͐̑̽̽2̷̛̛̞͛̌̈͋͆́̅͂̑̄̓̃͝2̵̼̐̅̃̍̽̊̏͊̈́̄̍͋̚͘̚2̴̧̢̱̭̗̳̺͉͓̭͔͔̃͑̀ͅ2̴̹̯̭͍̲͍̏̈́̀̅̏̊͗̂̂̑̓̾͒ͅ2̶̺͖̙̍̌̉̃͊̔̐̂͒̉́͑2̷̢̛̛̜͉̣̲̱̫̓͆̇̆̈́̅̍̈́͐̀̉̉2̶̬̺̗͛̚2̷̳̘̥̺̳̗̓̍̍2̵̢̨̫͚̣͚͓͙̭̩̑̿͜2̷͈̍́͂̄̚";
        }
    }
}