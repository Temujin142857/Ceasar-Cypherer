namespace CeasarCypherer
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private Boolean isKey = false;
        private Boolean isText = false;
        private int key;
        private String text;

        private void Key_Textbox_TextChanged(object sender, EventArgs e){
            if (Key_Textbox.Text != null) {
                try { key = int.Parse(Key_Textbox.Text); isKey = true; }
                catch { isKey = false; }
                  
            }
            if (isKey && isText) { solve(key, text); }
        }

        private void Input_Textbox_TextChanged(object sender, EventArgs e){
            if(Input_Textbox.Text != null) { isText = true; text = Input_Textbox.Text; }
            if(isKey&&isText) { solve(key, text); }
        }

        private void Decode_CheckedChanged(object sender, EventArgs e){
            if (isKey && isText) { solve(key, text); }
        }

        private void Encode_CheckedChanged(object sender, EventArgs e){
            if (isKey && isText) { solve(key, text); }
        }
      

        private void solve(int key, String text) {
            String result = "";
            int askii;
            if (Encode.Checked == false){ key = -key; }
            foreach (Char c in text)
            {
                
                askii = (int)c;
                int temp;
                if (64<askii&&askii<91)
                {
                    temp=((askii%65) + key)%26 + 65;
                    if (temp < 65) { temp += 26; }
                    result += (char)temp;
                    
                }
                else if (96 < askii && askii < 123)
                {
                    temp=(char)(((askii % 97) + key)%26 + 97);
                    if (temp < 97) { temp += 26; }
                    result += (char)temp;
                }
                else { result += c; }
            }
            update_Result(result); 
        }

        private void update_Result(String text) { Result_Textbox.Text = text; }//might need to refresh display to make it update

        
    }
}