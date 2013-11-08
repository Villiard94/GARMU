using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GARMU.Modele;
using GARMU.Controleur;

namespace GARMU
{
    public partial class frmPrincipal : Form
    {
        #region Membres

        //Les RichTextBox et TextBox des créations dynamiques de la planification mensuelle et du plan de travail. 
        Vue.NumberedRichTextBox[,] _rtbsPlanif = new Vue.NumberedRichTextBox[6, 5];
        Vue.NumberedRichTextBox[,] _rtbsPlanTrav = new Vue.NumberedRichTextBox[5, 7];
        TextBox[,] _tbsDatesPlanTravail = new TextBox[5, 7];
        TextBox[,] _tbsRelevePlanTravail = new TextBox[5, 7];


        #endregion


        ModelBDGarmu _modelBDGarmu;
        ManagerVehicule _mVehicule;
        ManagerEmployee _mEmployee;
        ManagerPrioriteLocale _mPriorite;

        public frmPrincipal()
        {
            _modelBDGarmu = new ModelBDGarmu();
            _mVehicule = new ManagerVehicule(_modelBDGarmu.Context);
            _mEmployee = new ManagerEmployee(_modelBDGarmu.Context);
            _mPriorite = new ManagerPrioriteLocale(_modelBDGarmu.Context);

            this.DoubleBuffered = true;

            InitializeComponent();

            #region Génération de PlanifMensuelle

            const int colIndexStartPlanif = 1;
            const int rowIndexStartPlanif = 2;

            for (int i = rowIndexStartPlanif; i < tlpPlanifMensuelle.RowCount; i++)
            {
                for (int j = colIndexStartPlanif; j < tlpPlanifMensuelle.ColumnCount; j++)
                {
                    Vue.NumberedRichTextBox rtb = new Vue.NumberedRichTextBox();
            

                    rtb.BorderStyle = BorderStyle.None;
                    rtb.Name = String.Format("tbPm{0}{1}", i - 2, j - 1);

                    _rtbsPlanif[i - 2, j - 1] = rtb;

                    tlpPlanifMensuelle.Controls.Add(rtb, j, i);
                    rtb.Dock = DockStyle.Fill;
                }
            }
            #endregion

            #region Génération de PlanTravailEquipe

            const int colIndexStartPlan = 0;
            const int rowIndexStartPlan = 1;

            for (int i = rowIndexStartPlan; i < tlpPlanTravail.RowCount; i++)
            {
                for (int j = colIndexStartPlan; j < tlpPlanTravail.ColumnCount; j++)
                {
                    //Section de la création des dates
                    if (i % 2 != 0 && j % 3 != 2)
                    {
                        TextBox tb = new TextBox();
                        tb.Dock = DockStyle.Fill;
                        tb.Margin = new Padding(0);
                        tb.BorderStyle = BorderStyle.None;

                        // Ajout des Dates
                        if (j % 3 == 0)
                        {
                            _tbsDatesPlanTravail[(i - 1) / 2, j / 3] = tb;
                            tb.Text = String.Format("{0}, {1}", (i - 1) / 2, j / 3);
                        }
                        // Ajout des Releves
                        else if (j % 3 == 1)
                        {
                            _tbsRelevePlanTravail[(i - 1) / 2, j / 3] = tb;
                            tb.Text = String.Format("{0}, {1}", (i - 1) / 2, j / 3);
                        }


                        tlpPlanTravail.Controls.Add(tb, j, i);
                    }

                    //Section de la création des assignations
                    if (i % 2 == 0 && j % 3 == 0)
                    {
                        Vue.NumberedRichTextBox rtb = new Vue.NumberedRichTextBox();

                        tlpPlanTravail.Controls.Add(rtb, j, i);
                        tlpPlanTravail.SetColumnSpan(rtb, 3);

                        rtb.Dock = DockStyle.Fill;
                        rtb.Margin = new Padding(0);
                        rtb.BorderStyle = BorderStyle.None;

                        _rtbsPlanTrav[i / 2 - 1, j / 3] = rtb;
                    }

                }
            }


            #endregion

            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            vehiculeBindingSource.DataSource = _mVehicule.GetList();
            employeeBindingSource.DataSource = _mEmployee.GetList();
            patrouilleurBindingSource.DataSource = _modelBDGarmu.Context.Patrouilleur.ToList();
            PatrouilleurDataGridView.Location = employeeDataGridView.Location;
            PatrouilleurDataGridView.Size = employeeDataGridView.Size;
            PatrouilleurDataGridView.Visible = false;

            employeeDataGridView.AutoGenerateColumns = false;
            PatrouilleurDataGridView.AutoGenerateColumns = false;

            //Etc
            #region Elenver l'auto-génération des colonnes des GridViews pour nous permetter de les gerer nous mem
            //employeeDataGridView.AutoGenerateColumns = false;
            //dgvListeRequeteVigueur.AutoGenerateColumns = false;
            //dgvListeTache.AutoGenerateColumns = false;
            //prioriteLocaleDataGridView.AutoGenerateColumns = false;
            //dgvRapQuot.AutoGenerateColumns = false;
            //dgvRequeteFerme.AutoGenerateColumns = false;
            #endregion

            // cbRechercheTacheQuotPat.SelectedIndex = 0;

            _modelBDGarmu.Context.Database.Connection.Open();
        }


        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            tcFormulaires.Visible = false;
            //this.Cursor = Cursors.WaitCursor;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            tcFormulaires.Visible = true;
            //this.Cursor = Cursors.Default;
        }

        private void mnuAideItem_Click(object sender, EventArgs e)
        {
            GARMU.Vue.frmAPropos f = new GARMU.Vue.frmAPropos();
            f.Show();

        }

        #region Garbage
        private void tbReqNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxRequeteDemandeur_Enter(object sender, EventArgs e)
        {

        }

        private void tbRequeteDemandeurNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void tbRequeteDemandeurAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void tbRequeteDemandeurTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void tbRequeteDemandeurFax_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRequeteDemandeurEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void rbRequeteDemandeurOui_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbRequeteDemandeurNon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReqProbJeunes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReqProbVTT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReqProbBruit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReqProbVitesse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReqProbSign_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReqProbStationne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReqProbCamion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReqProbAutre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbReqProbAutre_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbReqDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbReqDescLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbReqDescMuni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void dtpRapQuot_ValueChanged(object sender, EventArgs e)
        {
            if (dtpRapQuot.Value > DateTime.Now)
            {
                bRechercherRapQuot.Enabled = false;
            }
            else
            {
                bRechercherRapQuot.Enabled = true;
            }
        }

        #region Transformer combobox datagridview
        private void HandleEditShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var cbo = e.Control as ComboBox;
            if (cbo == null)
            {
                return;
            }

            cbo.DropDownStyle = ComboBoxStyle.DropDown;
            cbo.Validating -= HandleComboBoxValidating;
            cbo.Validating += HandleComboBoxValidating;
        }

        private void HandleComboBoxValidating(object sender, CancelEventArgs e)
        {
            var combo = sender as DataGridViewComboBoxEditingControl;
            if (combo == null)
            {
                return;
            }
            if (!combo.Items.Contains(combo.Text)) //check if item is already in drop down, if not, add it to all
            {
                var comboColumn = this.dgvRapQuot.Columns[this.dgvRapQuot.CurrentCell.ColumnIndex]
                as DataGridViewComboBoxColumn;
                combo.Items.Add(combo.Text);
                comboColumn.Items.Add(combo.Text);
                this.dgvRapQuot.CurrentCell.Value = combo.Text;
            }
        }
        #endregion

        /// Au changement de la sélection de l'élément du datagridview des Assignations
        private void dgvRapQuot_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRapQuot.SelectedRows.Count == 0 || dgvRapQuot.SelectedRows[0].Cells["AssignationRapQuot"].Value == null)
            {
                bRapQuotVersActionsRequ.Enabled = false;
                bRapQuotVersSuiviRequ.Enabled = false;
                bRapQuotVersRequ.Enabled = false;
                return;
            }

            if (dgvRapQuot.SelectedRows[0].Cells["AssignationRapQuot"].Value.ToString() == "Rapport")
            {
                bRapQuotVersRequ.Enabled = true;
                bRapQuotVersSuiviRequ.Enabled = true;
                bRapQuotVersActionsRequ.Enabled = true;
            }
            else
            {
                bRapQuotVersRequ.Enabled = false;
                bRapQuotVersSuiviRequ.Enabled = false;
                bRapQuotVersActionsRequ.Enabled = false;
            }

        }

        private void VersActionsRequ_Click(object sender, EventArgs e)
        {
            GARMU.Vue.frmActionsRequete f = new GARMU.Vue.frmActionsRequete();
            f.Show();
        }

        private void VersSuiviRequ_Click(object sender, EventArgs e)
        {
            tcMenu.SelectedIndex = 2;
            tcRapports.SelectedIndex = 2;
        }

        private void VersRequete_Click(object sender, EventArgs e)
        {
            tcMenu.SelectedIndex = 1;
            tcFormulaires.SelectedIndex = 3;
        }

        private void cbSuiviVerifLieu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSuiviVerifInfraLieux.Checked == true)
            {
                gbSuiviSurveillance.Enabled = true;
            }
            else
            {
                gbSuiviSurveillance.Enabled = false;
            }
        }

        private void cbSuiviRetour_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSuiviRetour.Checked == true)
            {
                grpSuiviRetour.Enabled = true;

            }
            else
            {
                grpSuiviRetour.Enabled = false;
            }
        }

        private void cbSuiviPARL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSuiviPARL.Checked == true)
            {
                gbSuiviParl.Enabled = true;

            }
            else
            {
                gbSuiviParl.Enabled = false;
            }
        }



        private void bRechercherPlanif_Click(object sender, EventArgs e)
        {

        }

        private void bRechercherRequete_Click(object sender, EventArgs e)
        {
            //if (tbReqNo.Text == "43")
            //{
            //    tbRequeteDemandeurNom.Text = "Antonioni";
            //    tbRequeteDemandeurAdresse.Text = "357 rue Magnum";
            //    tbRequeteDemandeurTel.Text = "450-888-1337";
            //    tbRequeteDemandeurFax.Text = "450-888-8008";
            //    tbRequeteDemandeurEmail.Text = "I<3Guns@hotmail.com";

            //    rbRequeteDemandeurOui.Checked = true;

            //    cbReqProbVitesse.Checked = true;
            //    rtbReqDesc.Text = "Vitesse, 220 dans une zone de 40";
            //    tbReqDescLocal.Text = "Rue des Raisins";
            //    tbReqDescMuni.Text = "St-Hyacinthe";

            //    rtbReqVehiculeDesc.Text = " Nissan 350z noir avec muffler qui fait beaucoup trop de bruit et qui est beaucoup trop droppé, avec du camber)";
            //    cboReqVehiculeMarque.SelectedItem = "Nissan";
            //    cboReqVehiculeModele.SelectedItem = "350z";
            //    tbReqVehiculePlaque.Text = "8008135";

            //    cboPlaintePriseNom.SelectedItem = "Desjardins";
            //    dtpReqPlaintePriseDate.Value = DateTime.Now;
            //    tbReqPlaintePriseProvenance.Text = "Par Texto";

            //    rtbReqDescSuspect.Text = "Gwo chef bwandit, Assasin. Impwiqué dans affwaire kwidnapping";

            //    tbReqSuspect1Nom.Text = "Templar";
            //    tbReqSuspect1Prenom.Text = "Simon";
            //    tbReqSuspect1DDN.Text = "02-07-1994";
            //    rtbReqSuspect1Desc.Text = "Swag, yolo, swag swag yolo";
            //}
            //else
            //{
            //    tbRequeteDemandeurNom.Text = "";
            //    tbRequeteDemandeurAdresse.Text = "";
            //    tbRequeteDemandeurTel.Text = "";
            //    tbRequeteDemandeurFax.Text = "";
            //    tbRequeteDemandeurEmail.Text = "";

            //    rbRequeteDemandeurOui.Checked = false;

            //    cbReqProbVitesse.Checked = false;
            //    rtbReqDesc.Text = "";
            //    tbReqDescLocal.Text = "";
            //    tbReqDescMuni.Text = "";

            //    rtbReqVehiculeDesc.Text = "";
            //    cboReqVehiculeMarque.SelectedItem = "";
            //    cboReqVehiculeModele.SelectedItem = "";
            //    tbReqVehiculePlaque.Text = "";

            //    cboPlaintePriseNom.SelectedItem = "";
            //    dtpReqPlaintePriseDate.Value = DateTime.Now;
            //    tbReqPlaintePriseProvenance.Text = "";

            //    rtbReqDescSuspect.Text = "";

            //    tbReqSuspect1Nom.Text = "";
            //    tbReqSuspect1Prenom.Text = "";
            //    tbReqSuspect1DDN.Text = "";
            //    rtbReqSuspect1Desc.Text = "";
            //}
        }

        private void btnRechercherPlan_Click(object sender, EventArgs e)
        {


        }

        private void btnSuiviRecherche_Click(object sender, EventArgs e)
        {
            if (tbSuiviNoDemande.Text == "43")
            {
                cbSuiviPatrouilleurAssigne.SelectedItem = "Desjardins";
                dtpSuiviDateAgenda.Value = DateTime.Now;

                cbSuiviVerifInfraLieux.Checked = true;
                tbSuiviDureeTotalSurveillance.Text = "3";
                tbSuiviNbConstatsEmis.Text = "5";
                tbSuiviNbPoliciersParticipants.Text = "4";
                rbSuiviSurvPos.Checked = true;
                rtbSuiviCommentaires.Text = "Sans commentaires";

                cbSuiviRetour.Checked = true;
                cbSuiviRetourPar.SelectedItem = "DesJardins";
                dtpSuiviDateRetourDonneDemandeur.Value = DateTime.Now;
                tbSuiviRetourHrs.Text = "7";
                tbSuiviRetourMin.Text = "53";
                tbSuiviRetourMoyen.Text = "Texto";

                cbSuiviPARL.Checked = false;
            }
            else
            {
                cbSuiviPatrouilleurAssigne.SelectedItem = "Desjardins";
                dtpSuiviDateAgenda.Value = DateTime.Now;

                cbSuiviVerifInfraLieux.Checked = false;
                tbSuiviDureeTotalSurveillance.Text = "";
                tbSuiviNbConstatsEmis.Text = "";
                tbSuiviNbPoliciersParticipants.Text = "";
                rbSuiviSurvPos.Checked = false;
                rtbSuiviCommentaires.Text = "";

                cbSuiviRetour.Checked = false;
                cbSuiviRetourPar.SelectedItem = "";
                dtpSuiviDateRetourDonneDemandeur.Value = DateTime.Now;
                tbSuiviRetourHrs.Text = "";
                tbSuiviRetourMin.Text = "";
                tbSuiviRetourMoyen.Text = "";

                cbSuiviPARL.Checked = false;
            }
        }

        private void cbRequeteCircAutres_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRequeteCircAutres.Checked)
                tbRequeteCircAutres.Enabled = true;
            else
                tbRequeteCircAutres.Enabled = false;
        }

        private void bRechercherEmploye_Click(object sender, EventArgs e)
        {


            //if (nomTextBox.Text == "" && prenomTextBox.Text == "" && matriculeTextBox.Text == "" && noEquipeComboBox.SelectedItem == null && noVehiculeComboBox.SelectedItem == null)
            //{

            //    employeeDataGridView.DataSource = _mEmployee.GetList();
            //    return;
            //}

            //string nomEmp = nomTextBox.Text;
            //string prenomEmp = prenomTextBox.Text;
            //string matriculeEmp = matriculeTextBox.Text;
            //string equipeEmp = noEquipeComboBox.SelectedItem == null ? "" : noEquipeComboBox.SelectedItem.ToString();
            //string vehiculeEmp = noVehiculeComboBox.SelectedItem == null ? "" : noVehiculeComboBox.SelectedItem.ToString();

            //employeeDataGridView.DataSource = _mEmployee.SearchFor(nomEmp, prenomEmp, matriculeEmp, equipeEmp, vehiculeEmp);

        }

        private void bAjouterEmploye_Click(object sender, EventArgs e)
        {


            //if (nomTextBox.Text == "" && prenomTextBox.Text == "")
            //{
            //    MessageBox.Show("Veuillez entrer un nom et un prénom");
            //}
            //else
            //{
            //    if (matriculeTextBox.Text == "" && noEquipeComboBox.SelectedItem == null && noVehiculeComboBox.SelectedItem == null)
            //    {
            //        DialogResult drPatrouilleur = MessageBox.Show("Aucun Matricule, numéro d'équipe ou numéro de véhicule entrer. /n Voulez vous adjouter un employé simple?", "", MessageBoxButtons.YesNo);
            //        if (drPatrouilleur == DialogResult.Yes)
            //        {
            //            _mEmployee.Add(nomTextBox.Text, prenomTextBox.Text, "", "", "");
            //        }
            //        else if (drPatrouilleur == DialogResult.No)
            //        {
            //            return;
            //        }
            //    }

            //}



        }

        private void cbSuspectConnuRequete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSuspectConnuRequete.Checked)
                tlpSuspectConnuRequete.Enabled = true;
            else
                tlpSuspectConnuRequete.Enabled = false;
        }

        private void bRechercherNoRequete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention: cette opération remplacera tous les champs par les données recherchés. Voulz-vous vraiment continuer? / Ne plus me le demander:");
        }

        private void bRechercherPriorite_Click(object sender, EventArgs e)
        {
            //if (tbNomPriorite.Text == "")
            //{
            //    prioriteLocaleDataGridView.DataSource = _mPriorite.GetList();
            //    return;
            //}

            //prioriteLocaleDataGridView.DataSource = _mPriorite.SearchFor(tbNomPriorite.Text);
        }

        private void bAjouterPriorite_Click(object sender, EventArgs e)
        {
            //if (tbNomPriorite.Text != "")
            //{
            //    DialogResult drPriorite = MessageBox.Show("Vous-êtes sur le point d'ajouter une prioritée locale", "", MessageBoxButtons.OKCancel);
            //    if (drPriorite == DialogResult.OK)
            //    {
            //        _mPriorite.Add(tbNomPriorite.Text);
            //    }
            //    else if (drPriorite == DialogResult.Cancel)
            //    {
            //        return;
            //    }
            //}


        }

        private void bRechercherTachePatrouilleur_Click(object sender, EventArgs e)
        {

            //lRechercheParTachePat.ForeColor = Color.Black;

            //if (cbRechercheTacheQuotPat.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Sélectionnez une recherche existante.");
            //    lRechercheParTachePat.ForeColor = Color.Red;
            //    return;
            //}

            //string recherche = "";
            //int selectedIndex = -1;

            //switch (cbRechercheTacheQuotPat.SelectedIndex)
            //{
            //    case 0:
            //        recherche = tbNomPatrouilleurTache.Text;
            //        break;
            //    case 1:
            //        recherche = tbPrenomPatrouilleurTache.Text;
            //        break;
            //    case 2:
            //        recherche = tbMatriculePatrouilleurTache.Text;
            //        break;
            //    default:
            //        break;
            //}

            //dgvListeTache.DataSource = _cTacheQuotPat.SearchFor(recherche, selectedIndex);
        }

        #region Évenements de BD Véhicule

        private void bRechercherVehicule_Click(object sender, EventArgs e)
        {
            //Si le tb est vide on sort
            if ((tbRechercherVehicule.Text == ""))
            {
                vehiculeBindingSource.DataSource = _mVehicule.GetList();
                return;
            }

            string numeroVeh;

            try //essaie de convertir le string en int
            {
                int.Parse(tbRechercherVehicule.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Ceci n'est pas un numéro de véhicule valide");
                return;
            }

            numeroVeh = tbRechercherVehicule.Text;

            //Recherche le Véhicule
            vehiculeBindingSource.DataSource = _mVehicule.SearchFor(numeroVeh.ToString());

        }

        private void bAddVeh_Click(object sender, EventArgs e)
        {
            tbNoVeh.Clear();

            //Vers l'interface d'ajout
            gbRechercheVehicule.Enabled = false;
            gbListeVeh.Enabled = false;
            bModVeh.Enabled = false;
            bDeleteVeh.Enabled = false;
            dgvVeh.Visible = false;
            bSaveVeh.Visible = true;
            bCancelVeh.Visible = true;
            bAddVeh.Enabled = false;
        }

        private void bSaveVeh_Click(object sender, EventArgs e)
        {
            //Si le tb est vide on demande un numéro valide
            if (tbNoVeh.Text == "")
            {
                MessageBox.Show("Veuillez entrer un numéro valide.");
                return;
            }

            string numeroVeh;

            try //essaie de convertir le string en int
            {
                int.Parse(tbNoVeh.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ceci n'est pas un numéro de véhicule valide");
                return;
            }

            numeroVeh = tbNoVeh.Text;

            string msg = _mVehicule.Add(numeroVeh.ToString());
            MessageBox.Show(msg);

            //S'il n'y a pas d'erreur on retourne à l'interface d'édition
            if (msg == AppCst.SUCCESS)
            {
                //Retour à l'interface éditoriale
                gbRechercheVehicule.Enabled = true;
                gbListeVeh.Enabled = true;
                bModVeh.Enabled = true;
                bDeleteVeh.Enabled = true;
                dgvVeh.Visible = true;
                bSaveVeh.Visible = false;
                bCancelVeh.Visible = false;
                bAddVeh.Enabled = true;

                vehiculeBindingSource.DataSource = _mVehicule.GetList();
                tbNoVeh.Text = dgvVeh.SelectedRows[0].Cells[0].Value.ToString();

            }

        }

        private void bCancelVeh_Click(object sender, EventArgs e)
        {
            if (dgvVeh.SelectedRows.Count != 0)
                tbNoVeh.Text = dgvVeh.SelectedRows[0].Cells[0].Value.ToString();

            //Retour à l'interface éditoriale
            gbRechercheVehicule.Enabled = true;
            gbListeVeh.Enabled = true;
            bModVeh.Enabled = true;
            bDeleteVeh.Enabled = true;
            dgvVeh.Visible = true;
            bSaveVeh.Visible = false;
            bCancelVeh.Visible = false;
            bAddVeh.Enabled = true;
        }

        private void bModVeh_Click(object sender, EventArgs e)
        {
            //Mesure de sécurité^pour s'assurer qu'il y ait au moin une rangé de sélectionnée
            if (dgvVeh.SelectedRows.Count < 0)
                return;

            string oldNoVeh = "";
            string newNoVeh = "";

            //S'assurer que ce sont des numéros valide
            try
            {
                int.Parse(dgvVeh.SelectedRows[0].Cells[0].Value.ToString());
                int.Parse(tbNoVeh.Text);
            }
            catch
            {
                MessageBox.Show("Numéro de véhicule invalide");
                tbNoVeh.Text = dgvVeh.SelectedRows[0].Cells[0].Value.ToString();
            }

            //Assigner les numéro de véhicules
            oldNoVeh = dgvVeh.SelectedRows[0].Cells[0].Value.ToString();
            newNoVeh = tbNoVeh.Text;

            //Aller chercher le véhicule en question
            Vehicule v = _mVehicule.SearchFor(oldNoVeh).First();

            //Modifier le véhicule
            string msg = _mVehicule.Modify(v, newNoVeh);

            if (msg != AppCst.SUCCESS)
                MessageBox.Show(msg);

            //Refresh du gridView
            dgvVeh.Refresh();
        }

        private void dgvVeh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVeh.SelectedRows.Count != 0)
                tbNoVeh.Text = dgvVeh.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void bDeleteVeh_Click(object sender, EventArgs e)
        {
            if (dgvVeh.SelectedRows.Count != 0)
                _mVehicule.Delete(dgvVeh.SelectedRows[0].Cells[0].Value.ToString(), null);

            //Refresh du gridView
            vehiculeBindingSource.DataSource = _mVehicule.GetList();
        }

        private void bAfficherToutVehicule_Click(object sender, EventArgs e)
        {
            vehiculeBindingSource.DataSource = _mVehicule.GetList();
        }

        #endregion



        #region Évenements de BD employé


        private void rbEmployeeTout_CheckedChanged_1(object sender, EventArgs e)
        {
            employeeDataGridView.Visible = true;
            PatrouilleurDataGridView.Visible = false;
        }

        private void rbEployeePat_CheckedChanged_1(object sender, EventArgs e)
        {
            employeeDataGridView.Visible = false;
            PatrouilleurDataGridView.Visible = true;
        }



        #endregion






    }
}
