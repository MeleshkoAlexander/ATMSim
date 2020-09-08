using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Presentors;
using ATM.View;
using System.IO.Ports;
namespace ATM.Presentors
{
    class PresentorATMInput
    {
        ATMInput atmInput;
        Model myModel;
        public PresentorATMInput(ATMInput view, Model m)
        {
            atmInput = view;
            myModel = m;
            atmInput.InputNumbCardClick += InputNumbCardClickHandeler;
        }
        StructCard SearchCard(List<StructCard> Cards, out int numb)
        {
            numb = -1;
            foreach (StructCard Card in Cards)
            {
                numb++;
                if (myModel.equals(Card.getNumbcard(), atmInput.TextNumberCard.Text))
                {
                    return Card;
                }
            }
            return null;
        }
        void InputNumbCardClickHandeler(object sender, EventArgs e)
        {
            int numb = 0;
            numb = IOF.InputXmlFile(numb, "Card.xml", myModel.list());
            StructCard Card = SearchCard(myModel.list(), out numb);
            if (!(Card == null))
            {
                if (atmInput.TextPassword.Text == Card.getPaswrod().ToString())
                {
                    atmInput.Hide();
                    ATMMenu ATMMenu = new ATMMenu();
                    _ = new PresentorATMMenu(ATMMenu, myModel);
                    myModel.IndexIn(numb);
                    ATMMenu.ShowDialog();
                    atmInput.Show();
                    atmInput.Hide();
                }
                else
                {
                    MessageBox.Show("Error Pasword", "Error");
                }
            }
            else
            {
                MessageBox.Show("This card is not exist", "Error");
            }
        }
    }
}
