using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice_2_Presentation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calculer_Click(object sender, EventArgs e)
        {
            error.Text = "";
            if (isTousRempli()==false) return;

            #region Le prix unitaire(Float > 0)

            float prix =0;
            if(float.TryParse(PrixUnitaire.Text,out prix))
            {
                if(prix<0)
                    error.Text += "- Prix Unitaire invalide <br/>";
            }
            else
            {
                error.Text += "- Prix Unitaire invalide <br/>";
            }
            #endregion

            #region la quantité(entier> 0)
            int quan = 0;
            if (int.TryParse(Quantite.Text, out quan))
            {
                if (quan < 0)
                    error.Text += "- Quantite invalide <br/>";
            }
            else
            {
                error.Text += "- Quantite invalide <br/>";
            }
            #endregion

            #region TVA(Float > 0)
            float tva = 0;
            if (float.TryParse(TVA.Text, out tva))
            {
                if (tva < 0)
                    error.Text += "- TVA invalide <br/>";
            }
            else
            {
                error.Text += "- TVA invalide <br/>";
            }
            #endregion
        }
      
        private bool isTousRempli()
        {
            foreach (Control control in form1.Controls)
            {
                if (control is TextBox)
                    if (string.IsNullOrEmpty(((TextBox)control).Text))
                    {
                        error.Text = "Tous les champs sont obligatoires !";
                        return false;
                    }
            }
            return true;
        }
    }
}