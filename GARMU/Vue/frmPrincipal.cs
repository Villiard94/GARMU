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


            #region Initialisation RTB


            InitializeComponent();

            rtbSituationSecurTransport.SelectionBullet = true;
            rtbActionCrime.SelectionBullet = true;
            rtbActionDivers.SelectionBullet = true;
            rtbActionDrogue.SelectionBullet = true;
            rtbActionSecurMilieu.SelectionBullet = true;
            rtbActionSecurTransport.SelectionBullet = true;
            rtbActionVisi.SelectionBullet = true;
            rtbAttenduCrime.SelectionBullet = true;
            rtbAttenduDivers.SelectionBullet = true;
            rtbAttenduDrogue.SelectionBullet = true;
            rtbAttenduSecurMilieu.SelectionBullet = true;
            rtbAttenduSecurTransport.SelectionBullet = true;
            rtbAttenduVisi.SelectionBullet = true;
            rtbEndroitCrime.SelectionBullet = true;
            rtbEndroitDivers.SelectionBullet = true;
            rtbEndroitDrogue.SelectionBullet = true;
            rtbEndroitSecurMilieu.SelectionBullet = true;
            rtbEndroitSecurTransport.SelectionBullet = true;
            rtbEndroitVisi.SelectionBullet = true;
            rtbObtenuCrime.SelectionBullet = true;
            rtbObtenuDivers.SelectionBullet = true;
            rtbObtenuDrogue.SelectionBullet = true;
            rtbObtenuSecurMilieu.SelectionBullet = true;
            rtbObtenuSecurTransport.SelectionBullet = true;
            rtbObtenuVisi.SelectionBullet = true;
            rtbSituationCrime.SelectionBullet = true;
            rtbSituationDivers.SelectionBullet = true;
            rtbSituationDrogue.SelectionBullet = true;
            rtbSituationSecurMilieu.SelectionBullet = true;
            rtbSituationSecurTransport.SelectionBullet = true;
            rtbSituationVisi.SelectionBullet = true;
            rtbTravailDim1.SelectionBullet = true;
            rtbTravailDim2.SelectionBullet = true;
            rtbTravailDim3.SelectionBullet = true;
            rtbTravailDim4.SelectionBullet = true;
            rtbTravailJeu1.SelectionBullet = true;
            rtbTravailJeu2.SelectionBullet = true;
            rtbTravailJeu3.SelectionBullet = true;
            rtbTravailJeu4.SelectionBullet = true;
            rtbTravailLun1.SelectionBullet = true;
            rtbTravailLun2.SelectionBullet = true;
            rtbTravailLun3.SelectionBullet = true;
            rtbTravailLun4.SelectionBullet = true;
            rtbTravailMardi1.SelectionBullet = true;
            rtbTravailMardi2.SelectionBullet = true;
            rtbTravailMardi3.SelectionBullet = true;
            rtbTravailMardi4.SelectionBullet = true;
            rtbTravailMer1.SelectionBullet = true;
            rtbTravailMer2.SelectionBullet = true;
            rtbTravailMer3.SelectionBullet = true;
            rtbTravailMer4.SelectionBullet = true;
            rtbTravailSam1.SelectionBullet = true;
            rtbTravailSam2.SelectionBullet = true;
            rtbTravailSam3.SelectionBullet = true;
            rtbTravailSam4.SelectionBullet = true;
            rtbTravailMardi1.SelectionBullet = true;
            rtbTravailMardi2.SelectionBullet = true;
            rtbTravailMardi3.SelectionBullet = true;
            rtbTravailMardi4.SelectionBullet = true;



            #endregion


        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            vehiculeBindingSource.DataSource = _mVehicule.GetList();


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
            this.Cursor = Cursors.WaitCursor;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            tcFormulaires.Visible = true;
            this.Cursor = Cursors.Default;
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
            if ((string)cbMoisPlanif.SelectedItem == "Mars" && (string)cbAnneePlanif.SelectedItem == "2013")
            {
                tbThemePlanif.Text = "Le cellulaire au volant!";

                rtbSituationVisi.Text = "Plan de parrainage";
                rtbSituationSecurMilieu.Text = "Attroupements dans les endroits publics";
                rtbSituationSecurTransport.Text = "A) Vitesse sur l'ensemble du territoire \n B) Conduite capacités affaiblies";
                rtbSituationCrime.Text = "A) Indroduction effraction secteurs commerciaux et industriels";
                rtbSituationDrogue.Text = "Visites et présence près des bars";
                rtbSituationDivers.Text = "A) Surveillance Circuit VTT et Motoneige-circulation sur la rivière";

                rtbEndroitVisi.Text = "Toutes les municipalités";
                rtbEndroitSecurMilieu.Text = "Maison des jeunes \n Piscines \n Arénas";
                rtbEndroitSecurTransport.Text = "A) Sites accidentogênes \n B) Endroits stratégiques";
                rtbEndroitCrime.Text = "A) Parcs et secteurs industriels";
                rtbEndroitDrogue.Text = "Visites et présence près des bars";
                rtbEndroitDivers.Text = "A) Croisement des circuits et des routes et la Yamaska";

                rtbActionVisi.Text = "Rencontre avec les personnes désignées dans les défférentes municipalités";
                rtbActionSecurMilieu.Text = "Application du G-200 \n Visibilité et prévention";
                rtbActionSecurTransport.Text = "A) Opération radar \n B) Barrage routier contre l'alcool endroi au choix";
                rtbActionCrime.Text = "A) Patrouille préventive et/ou banalisé";
                rtbActionDrogue.Text = "Présence extérieur et/ou visites intérieurs";
                rtbActionDivers.Text = "A)Opérations ciblés **(selon les conditions)";

                rtbAttenduVisi.Text = "Selon le plan de parrainage";
                rtbAttenduSecurMilieu.Text = "Assignations chaque relèves de soir et jours de classe (retour 518)";
                rtbAttenduSecurTransport.Text = "A) 12 opérations par équipe (compléter PARL) \n B) 1 par équipe (compléter PARL)";
                rtbAttenduCrime.Text = "A) Assignation de soir et nuit (retour 518)";
                rtbAttenduDrogue.Text = "Assignation de soir et nuit (retour 518 et rapport de visite)";
                rtbAttenduDivers.Text = "A) 1 opération par équipe \n 2 opérations pour l'équipe Multi (compléter PARL)";

                rtbObtenuVisi.Text = "Oui";
                rtbObtenuSecurMilieu.Text = "Non";
                rtbObtenuSecurTransport.Text = "A) 8/12 \n B) 1/1";
                rtbObtenuCrime.Text = "Oui";
                rtbObtenuDrogue.Text = "Non";
                rtbObtenuDivers.Text = "A) 1/1 \n 1/2";

            }
            else
            {
                tbThemePlanif.Text = "";

                rtbSituationVisi.Text = "";
                rtbSituationSecurMilieu.Text = "";
                rtbSituationSecurTransport.Text = "";
                rtbSituationCrime.Text = "";
                rtbSituationDrogue.Text = "";
                rtbSituationDivers.Text = "";

                rtbEndroitVisi.Text = "";
                rtbEndroitSecurMilieu.Text = "";
                rtbEndroitSecurTransport.Text = "";
                rtbEndroitCrime.Text = "";
                rtbEndroitDrogue.Text = "";
                rtbEndroitDivers.Text = "";

                rtbActionVisi.Text = "";
                rtbActionSecurMilieu.Text = "";
                rtbActionSecurTransport.Text = "";
                rtbActionCrime.Text = "";
                rtbActionDrogue.Text = "";
                rtbActionDivers.Text = "";

                rtbAttenduVisi.Text = "";
                rtbAttenduSecurMilieu.Text = "";
                rtbAttenduSecurTransport.Text = "";
                rtbAttenduCrime.Text = "";
                rtbAttenduDrogue.Text = "";
                rtbAttenduDivers.Text = "";

                rtbObtenuVisi.Text = "";
                rtbObtenuSecurMilieu.Text = "";
                rtbObtenuSecurTransport.Text = "";
                rtbObtenuCrime.Text = "";
                rtbObtenuDrogue.Text = "";
                rtbObtenuDivers.Text = "";
            }
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
            if ((string)cboPlanifEquipe.SelectedItem == "2" && (string)cboPlanifMois.SelectedItem == "Mars" && (string)cboPlanifAnne.SelectedItem == "2013")
            {
                tbDateVen1.Text = "1";
                tbDateVen2.Text = "8";
                tbDateVen3.Text = "15";
                tbDateVen4.Text = "22";
                tbReleveVen1.Text = "2";
                tbReleveVen2.Text = "H";
                tbReleveVen3.Text = "1";
                tbReleveVen4.Text = "1";

                tbDateSam1.Text = "2";
                tbDateSam2.Text = "9";
                tbDateSam3.Text = "16";
                tbDateSam4.Text = "23";
                tbReleveSam1.Text = "H";
                tbReleveSam2.Text = "2";
                tbReleveSam3.Text = "1";
                tbReleveSam4.Text = "1";

                tbDateDim1.Text = "";
                tbDateDim2.Text = "3";
                tbDateDim3.Text = "10";
                tbDateDim4.Text = "17";
                tbReleveDim1.Text = "";
                tbReleveDim2.Text = "H";
                tbReleveDim3.Text = "2";
                tbReleveDim4.Text = "H";

                tbDateLun1.Text = "";
                tbDateLun2.Text = "4";
                tbDateLun3.Text = "11";
                tbDateLun4.Text = "18";
                tbReleveLun1.Text = "";
                tbReleveLun2.Text = "3";
                tbReleveLun3.Text = "2";
                tbReleveLun4.Text = "H";

                tbDateMar1.Text = "";
                tbDateMar2.Text = "5";
                tbDateMar3.Text = "12";
                tbDateMar4.Text = "19";
                tbReleveMar1.Text = "";
                tbReleveMar2.Text = "3";
                tbReleveMar3.Text = "2";
                tbReleveMar4.Text = "2";

                tbDateMer1.Text = "";
                tbDateMer2.Text = "6";
                tbDateMer3.Text = "13";
                tbDateMer4.Text = "20";
                tbReleveMer1.Text = "";
                tbReleveMer2.Text = "3";
                tbReleveMer3.Text = "H";
                tbReleveMer4.Text = "2";

                tbDateJeu1.Text = "";
                tbDateJeu2.Text = "7";
                tbDateJeu3.Text = "14";
                tbDateJeu4.Text = "21";
                tbReleveJeu1.Text = "";
                tbReleveJeu2.Text = "H";
                tbReleveJeu3.Text = "H";
                tbReleveJeu4.Text = "H";

                rtbTravailVen1.Text = "Attroupement end. Pub \n Cinémomètre (PARL) \n Présence près écoles";
                rtbTravailVen2.Text = "";
                rtbTravailVen3.Text = "Patrouille sect. Industriel \n Patrouille près des bars";
                rtbTravailVen4.Text = "Cinémomètre (PARL) \n Opér Cellulaire (PARL)";

                rtbTravailSam1.Text = "";
                rtbTravailSam2.Text = "Cinémomètre (PARL) \n Croisement Vtt-Route";
                rtbTravailSam3.Text = "Barrage Alcool(PARL) \n Patrouille Sect Industriel \n Patrouille près des bars";
                rtbTravailSam4.Text = "Attroupement end. Pub \n Cinémomètre (PARL) \n Présence près écoles";

                rtbTravailDim1.Text = "";
                rtbTravailDim2.Text = "";
                rtbTravailDim3.Text = " Cinémomètre (PARL)";
                rtbTravailDim4.Text = "";

                rtbTravailLun1.Text = "";
                rtbTravailLun2.Text = "Attroupement end. Pub \n Cinémomètre (PARL)";
                rtbTravailLun3.Text = "Attroupement end. Pub \n Cinémomètre (PARL) \n Présence près écoles";
                rtbTravailLun4.Text = "";

                rtbTravailMardi1.Text = "";
                rtbTravailMardi2.Text = "Attroupement end. Pub \n Cinémomètre (PARL)";
                rtbTravailMardi3.Text = "Attroupement end. Pub \n Cinémomètre (PARL) \n Opér Silencieux";
                rtbTravailMardi4.Text = "Attroupement end. Pub \n Cinémomètre (PARL) \n Présence près écoles";

                rtbTravailMer1.Text = "";
                rtbTravailMer2.Text = "Attroupement end. Pub \n Cinémomètre (PARL) \n Opér cellulaire";
                rtbTravailMer3.Text = "s";
                rtbTravailMer4.Text = "Attroupement end. Pub \n Cinémomètre (PARL) \n Présence près écoles";

                rtbTravailJeu1.Text = "";
                rtbTravailJeu2.Text = "";
                rtbTravailJeu3.Text = "";
                rtbTravailJeu4.Text = "";


            }
            else
            {
                tbDateVen1.Text = "";
                tbDateVen2.Text = "";
                tbDateVen3.Text = "";
                tbDateVen4.Text = "";
                tbReleveVen1.Text = "";
                tbReleveVen2.Text = "";
                tbReleveVen3.Text = "";
                tbReleveVen4.Text = "";

                tbDateSam1.Text = "";
                tbDateSam2.Text = "";
                tbDateSam3.Text = "";
                tbDateSam4.Text = "";
                tbReleveSam1.Text = "";
                tbReleveSam2.Text = "";
                tbReleveSam3.Text = "";
                tbReleveSam4.Text = "";

                tbDateDim1.Text = "";
                tbDateDim2.Text = "";
                tbDateDim3.Text = "";
                tbDateDim4.Text = "";
                tbReleveDim1.Text = "";
                tbReleveDim2.Text = "";
                tbReleveDim3.Text = "";
                tbReleveDim4.Text = "";

                tbDateLun1.Text = "";
                tbDateLun2.Text = "";
                tbDateLun3.Text = "";
                tbDateLun4.Text = "";
                tbReleveLun1.Text = "";
                tbReleveLun2.Text = "";
                tbReleveLun3.Text = "";
                tbReleveLun4.Text = "";

                tbDateMar1.Text = "";
                tbDateMar2.Text = "";
                tbDateMar3.Text = "";
                tbDateMar4.Text = "";
                tbReleveMar1.Text = "";
                tbReleveMar2.Text = "";
                tbReleveMar3.Text = "";
                tbReleveMar4.Text = "";

                tbDateMer1.Text = "";
                tbDateMer2.Text = "";
                tbDateMer3.Text = "";
                tbDateMer4.Text = "";
                tbReleveMer1.Text = "";
                tbReleveMer2.Text = "";
                tbReleveMer3.Text = "";
                tbReleveMer4.Text = "";

                tbDateJeu1.Text = "";
                tbDateJeu2.Text = "";
                tbDateJeu3.Text = "";
                tbDateJeu4.Text = "";
                tbReleveJeu1.Text = "";
                tbReleveJeu2.Text = "";
                tbReleveJeu3.Text = "";
                tbReleveJeu4.Text = "";

                rtbTravailVen1.Text = "";
                rtbTravailVen2.Text = "";
                rtbTravailVen3.Text = "";
                rtbTravailVen4.Text = "";

                rtbTravailSam1.Text = "";
                rtbTravailSam2.Text = "";
                rtbTravailSam3.Text = "";
                rtbTravailSam4.Text = "";

                rtbTravailDim1.Text = "";
                rtbTravailDim2.Text = "";
                rtbTravailDim3.Text = ""; ;
                rtbTravailDim4.Text = "";

                rtbTravailLun1.Text = "";
                rtbTravailLun2.Text = "";
                rtbTravailLun3.Text = "";
                rtbTravailLun4.Text = "";

                rtbTravailMardi1.Text = "";
                rtbTravailMardi2.Text = "";
                rtbTravailMardi3.Text = "";
                rtbTravailMardi4.Text = "";

                rtbTravailMer1.Text = "";
                rtbTravailMer2.Text = "";
                rtbTravailMer3.Text = "";
                rtbTravailMer4.Text = "";

                rtbTravailJeu1.Text = "";
                rtbTravailJeu2.Text = "";
                rtbTravailJeu3.Text = "";
                rtbTravailJeu4.Text = "";
            }
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

            if(msg != AppCst.SUCCESS)
                MessageBox.Show(msg);

            //Refresh du gridView
            dgvVeh.Refresh();
        }

        private void dgvVeh_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvVeh.SelectedRows.Count != 0)
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







    }
}
