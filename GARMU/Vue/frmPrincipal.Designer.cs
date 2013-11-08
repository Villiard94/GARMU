namespace GARMU
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAideItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRapports = new System.Windows.Forms.TabPage();
            this.tcRapports = new System.Windows.Forms.TabControl();
            this.tabRequeteVigueur = new System.Windows.Forms.TabPage();
            this.demandeSpecialeDataGridView = new System.Windows.Forms.DataGridView();
            this.tabRequeteFerme = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabSuiviRequete = new System.Windows.Forms.TabPage();
            this.btnSuiviRecherche = new System.Windows.Forms.Button();
            this.btnSuiviAjout = new System.Windows.Forms.Button();
            this.grpSuiviRetour = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.dtpSuiviDateRetourDonneDemandeur = new System.Windows.Forms.DateTimePicker();
            this.cbSuiviRetourPar = new System.Windows.Forms.ComboBox();
            this.tbSuiviRetourMin = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.tbSuiviRetourMoyen = new System.Windows.Forms.TextBox();
            this.tbSuiviRetourHrs = new System.Windows.Forms.TextBox();
            this.cbSuiviPARL = new System.Windows.Forms.CheckBox();
            this.cbSuiviRetour = new System.Windows.Forms.CheckBox();
            this.gbSuiviSurveillance = new System.Windows.Forms.GroupBox();
            this.rtbSuiviCommentaires = new System.Windows.Forms.RichTextBox();
            this.rbSuiviSurvNeg = new System.Windows.Forms.RadioButton();
            this.rbSuiviSurvPos = new System.Windows.Forms.RadioButton();
            this.label68 = new System.Windows.Forms.Label();
            this.tbSuiviDureeTotalSurveillance = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.tbSuiviNbConstatsEmis = new System.Windows.Forms.TextBox();
            this.tbSuiviNbPoliciersParticipants = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.cbSuiviPatrouilleurAssigne = new System.Windows.Forms.ComboBox();
            this.cbSuiviVerifInfraLieux = new System.Windows.Forms.CheckBox();
            this.tbSuiviNoDemande = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.dtpSuiviDateAgenda = new System.Windows.Forms.DateTimePicker();
            this.gbSuiviParl = new System.Windows.Forms.GroupBox();
            this.cbSuiviContolePar = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.cbSuiviAlimentePar = new System.Windows.Forms.ComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.tabFormulaire = new System.Windows.Forms.TabPage();
            this.tcFormulaires = new System.Windows.Forms.TabControl();
            this.tabPlanif = new System.Windows.Forms.TabPage();
            this.bEnregistrerPlanif = new System.Windows.Forms.Button();
            this.bRechercherPlanif = new System.Windows.Forms.Button();
            this.cbAnneePlanif = new System.Windows.Forms.ComboBox();
            this.cbMoisPlanif = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbThemePlanif = new System.Windows.Forms.TextBox();
            this.lTheme = new System.Windows.Forms.Label();
            this.tlpPlanifMensuelle = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPlanEquipe = new System.Windows.Forms.TabPage();
            this.btnEnregistrerPlan = new System.Windows.Forms.Button();
            this.btnRechercherPlan = new System.Windows.Forms.Button();
            this.cboPlanifAnne = new System.Windows.Forms.ComboBox();
            this.cboPlanifMois = new System.Windows.Forms.ComboBox();
            this.cboPlanifEquipe = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tlpPlanTravail = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabRapportQuot = new System.Windows.Forms.TabPage();
            this.bRapQuotVersRequ = new System.Windows.Forms.Button();
            this.bRapQuotVersSuiviRequ = new System.Windows.Forms.Button();
            this.bRapQuotVersActionsRequ = new System.Windows.Forms.Button();
            this.dgvRapQuot = new System.Windows.Forms.DataGridView();
            this.MatriculeRapQuot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PatrouilleurRapQuot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SecteurRapQuot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VehiculeRapQuot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AssignationRapQuot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FaitRapQuot = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bRechercherRapQuot = new System.Windows.Forms.Button();
            this.bEnregistrerRapQuot = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbReleveRapQuot = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.cbEquipeRapQuot = new System.Windows.Forms.ComboBox();
            this.dtpRapQuot = new System.Windows.Forms.DateTimePicker();
            this.cboReqPlaintePriseNom = new System.Windows.Forms.TabPage();
            this.dtpDateRequete = new System.Windows.Forms.DateTimePicker();
            this.bRechercherNoRequete = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tbDemandeRecuRequete = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbPlaintePriseParRequete = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.cbSuspectConnuRequete = new System.Windows.Forms.CheckBox();
            this.tlpSuspectConnuRequete = new System.Windows.Forms.TableLayoutPanel();
            this.tbDescPhysSuspect2Requete = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.tbNomSuspect1Requete = new System.Windows.Forms.TextBox();
            this.tbPrenomSuspect1Requete = new System.Windows.Forms.TextBox();
            this.tbDateNaissanceSuspect1Requete = new System.Windows.Forms.TextBox();
            this.tbDescPhysSuspect1Requete = new System.Windows.Forms.TextBox();
            this.tbNomSuspect2Requete = new System.Windows.Forms.TextBox();
            this.tbPrenomSuspect2Requete = new System.Windows.Forms.TextBox();
            this.tbDateNaissanceSuspect2Requete = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tbContrevenantDemeureRequete = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbDescriptionSuspectRequete = new System.Windows.Forms.RichTextBox();
            this.tbMunicipaliteRequete = new System.Windows.Forms.TextBox();
            this.tbLocalisationRequete = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.lLocalisationRequete = new System.Windows.Forms.Label();
            this.bgDescriptionDemande = new System.Windows.Forms.GroupBox();
            this.rtbDescriptionDemande = new System.Windows.Forms.RichTextBox();
            this.tbRequeteCircAutres = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.cbRequeteCircAutres = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabBD = new System.Windows.Forms.TabPage();
            this.tcBD = new System.Windows.Forms.TabControl();
            this.tabEmployes = new System.Windows.Forms.TabPage();
            this.tabPriorites = new System.Windows.Forms.TabPage();
            this.bAjouterPriorite = new System.Windows.Forms.Button();
            this.bRechercherPriorite = new System.Windows.Forms.Button();
            this.tabTaches = new System.Windows.Forms.TabPage();
            this.bRechercherTachePatrouilleur = new System.Windows.Forms.Button();
            this.tabVeh = new System.Windows.Forms.TabPage();
            this.gbEditVeh = new System.Windows.Forms.GroupBox();
            this.tbNoVeh = new System.Windows.Forms.TextBox();
            this.lNoVeh = new System.Windows.Forms.Label();
            this.bDeleteVeh = new System.Windows.Forms.Button();
            this.bCancelVeh = new System.Windows.Forms.Button();
            this.bSaveVeh = new System.Windows.Forms.Button();
            this.bModVeh = new System.Windows.Forms.Button();
            this.bAddVeh = new System.Windows.Forms.Button();
            this.gbListeVeh = new System.Windows.Forms.GroupBox();
            this.dgvVeh = new System.Windows.Forms.DataGridView();
            this.gbRechercheVehicule = new System.Windows.Forms.GroupBox();
            this.bAfficherToutVehicule = new System.Windows.Forms.Button();
            this.tbRechercherVehicule = new System.Windows.Forms.TextBox();
            this.bRechercherVehicule = new System.Windows.Forms.Button();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.bSuppEmp = new System.Windows.Forms.Button();
            this.bCancelEmp = new System.Windows.Forms.Button();
            this.bSaveEmp = new System.Windows.Forms.Button();
            this.bModEmp = new System.Windows.Forms.Button();
            this.bAjoutEmp = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PatrouilleurDataGridView = new System.Windows.Forms.DataGridView();
            this.rbEployeePat = new System.Windows.Forms.RadioButton();
            this.rbEmployeeTout = new System.Windows.Forms.RadioButton();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bAffEmp = new System.Windows.Forms.Button();
            this.tbRechercheEmp = new System.Windows.Forms.TextBox();
            this.bEmpRec = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRechercheEmp = new System.Windows.Forms.Label();
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patrouilleurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabRapports.SuspendLayout();
            this.tcRapports.SuspendLayout();
            this.tabRequeteVigueur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demandeSpecialeDataGridView)).BeginInit();
            this.tabRequeteFerme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabSuiviRequete.SuspendLayout();
            this.grpSuiviRetour.SuspendLayout();
            this.gbSuiviSurveillance.SuspendLayout();
            this.gbSuiviParl.SuspendLayout();
            this.tabFormulaire.SuspendLayout();
            this.tcFormulaires.SuspendLayout();
            this.tabPlanif.SuspendLayout();
            this.tlpPlanifMensuelle.SuspendLayout();
            this.tabPlanEquipe.SuspendLayout();
            this.tlpPlanTravail.SuspendLayout();
            this.tabRapportQuot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapQuot)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.cboReqPlaintePriseNom.SuspendLayout();
            this.tlpSuspectConnuRequete.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.bgDescriptionDemande.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabBD.SuspendLayout();
            this.tcBD.SuspendLayout();
            this.tabEmployes.SuspendLayout();
            this.tabPriorites.SuspendLayout();
            this.tabTaches.SuspendLayout();
            this.tabVeh.SuspendLayout();
            this.gbEditVeh.SuspendLayout();
            this.gbListeVeh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).BeginInit();
            this.gbRechercheVehicule.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatrouilleurDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrouilleurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1466, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAideItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // mnuAideItem
            // 
            this.mnuAideItem.Name = "mnuAideItem";
            this.mnuAideItem.Size = new System.Drawing.Size(131, 22);
            this.mnuAideItem.Text = "À propos...";
            this.mnuAideItem.Click += new System.EventHandler(this.mnuAideItem_Click);
            // 
            // tabRapports
            // 
            this.tabRapports.Controls.Add(this.tcRapports);
            this.tabRapports.Location = new System.Drawing.Point(4, 54);
            this.tabRapports.Name = "tabRapports";
            this.tabRapports.Size = new System.Drawing.Size(1443, 594);
            this.tabRapports.TabIndex = 2;
            this.tabRapports.Text = "Rapports";
            this.tabRapports.UseVisualStyleBackColor = true;
            // 
            // tcRapports
            // 
            this.tcRapports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcRapports.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcRapports.Controls.Add(this.tabRequeteVigueur);
            this.tcRapports.Controls.Add(this.tabRequeteFerme);
            this.tcRapports.Controls.Add(this.tabSuiviRequete);
            this.tcRapports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcRapports.Location = new System.Drawing.Point(3, 0);
            this.tcRapports.Name = "tcRapports";
            this.tcRapports.SelectedIndex = 0;
            this.tcRapports.Size = new System.Drawing.Size(1435, 591);
            this.tcRapports.TabIndex = 0;
            // 
            // tabRequeteVigueur
            // 
            this.tabRequeteVigueur.Controls.Add(this.demandeSpecialeDataGridView);
            this.tabRequeteVigueur.Location = new System.Drawing.Point(4, 25);
            this.tabRequeteVigueur.Name = "tabRequeteVigueur";
            this.tabRequeteVigueur.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequeteVigueur.Size = new System.Drawing.Size(1427, 562);
            this.tabRequeteVigueur.TabIndex = 0;
            this.tabRequeteVigueur.Text = "Liste requête en vigueur";
            this.tabRequeteVigueur.UseVisualStyleBackColor = true;
            // 
            // demandeSpecialeDataGridView
            // 
            this.demandeSpecialeDataGridView.AllowUserToAddRows = false;
            this.demandeSpecialeDataGridView.AllowUserToDeleteRows = false;
            this.demandeSpecialeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandeSpecialeDataGridView.Location = new System.Drawing.Point(15, 6);
            this.demandeSpecialeDataGridView.Name = "demandeSpecialeDataGridView";
            this.demandeSpecialeDataGridView.ReadOnly = true;
            this.demandeSpecialeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.demandeSpecialeDataGridView.Size = new System.Drawing.Size(1393, 564);
            this.demandeSpecialeDataGridView.TabIndex = 0;
            // 
            // tabRequeteFerme
            // 
            this.tabRequeteFerme.Controls.Add(this.dataGridView1);
            this.tabRequeteFerme.Location = new System.Drawing.Point(4, 25);
            this.tabRequeteFerme.Name = "tabRequeteFerme";
            this.tabRequeteFerme.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequeteFerme.Size = new System.Drawing.Size(1427, 562);
            this.tabRequeteFerme.TabIndex = 1;
            this.tabRequeteFerme.Text = "Liste requête fermé";
            this.tabRequeteFerme.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1393, 564);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabSuiviRequete
            // 
            this.tabSuiviRequete.Controls.Add(this.btnSuiviRecherche);
            this.tabSuiviRequete.Controls.Add(this.btnSuiviAjout);
            this.tabSuiviRequete.Controls.Add(this.grpSuiviRetour);
            this.tabSuiviRequete.Controls.Add(this.cbSuiviPARL);
            this.tabSuiviRequete.Controls.Add(this.cbSuiviRetour);
            this.tabSuiviRequete.Controls.Add(this.gbSuiviSurveillance);
            this.tabSuiviRequete.Controls.Add(this.cbSuiviPatrouilleurAssigne);
            this.tabSuiviRequete.Controls.Add(this.cbSuiviVerifInfraLieux);
            this.tabSuiviRequete.Controls.Add(this.tbSuiviNoDemande);
            this.tabSuiviRequete.Controls.Add(this.label67);
            this.tabSuiviRequete.Controls.Add(this.dtpSuiviDateAgenda);
            this.tabSuiviRequete.Controls.Add(this.gbSuiviParl);
            this.tabSuiviRequete.Controls.Add(this.label66);
            this.tabSuiviRequete.Controls.Add(this.label64);
            this.tabSuiviRequete.Location = new System.Drawing.Point(4, 25);
            this.tabSuiviRequete.Name = "tabSuiviRequete";
            this.tabSuiviRequete.Size = new System.Drawing.Size(1427, 562);
            this.tabSuiviRequete.TabIndex = 2;
            this.tabSuiviRequete.Text = "Suivi d\'une requête";
            this.tabSuiviRequete.UseVisualStyleBackColor = true;
            // 
            // btnSuiviRecherche
            // 
            this.btnSuiviRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuiviRecherche.Location = new System.Drawing.Point(897, 10);
            this.btnSuiviRecherche.Name = "btnSuiviRecherche";
            this.btnSuiviRecherche.Size = new System.Drawing.Size(158, 50);
            this.btnSuiviRecherche.TabIndex = 65;
            this.btnSuiviRecherche.Text = "Rechercher";
            this.btnSuiviRecherche.UseVisualStyleBackColor = true;
            this.btnSuiviRecherche.Click += new System.EventHandler(this.btnSuiviRecherche_Click);
            // 
            // btnSuiviAjout
            // 
            this.btnSuiviAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuiviAjout.Location = new System.Drawing.Point(1061, 10);
            this.btnSuiviAjout.Name = "btnSuiviAjout";
            this.btnSuiviAjout.Size = new System.Drawing.Size(158, 50);
            this.btnSuiviAjout.TabIndex = 63;
            this.btnSuiviAjout.Text = "Ajouter";
            this.btnSuiviAjout.UseVisualStyleBackColor = true;
            // 
            // grpSuiviRetour
            // 
            this.grpSuiviRetour.Controls.Add(this.label62);
            this.grpSuiviRetour.Controls.Add(this.dtpSuiviDateRetourDonneDemandeur);
            this.grpSuiviRetour.Controls.Add(this.cbSuiviRetourPar);
            this.grpSuiviRetour.Controls.Add(this.tbSuiviRetourMin);
            this.grpSuiviRetour.Controls.Add(this.label58);
            this.grpSuiviRetour.Controls.Add(this.label55);
            this.grpSuiviRetour.Controls.Add(this.label56);
            this.grpSuiviRetour.Controls.Add(this.label57);
            this.grpSuiviRetour.Controls.Add(this.tbSuiviRetourMoyen);
            this.grpSuiviRetour.Controls.Add(this.tbSuiviRetourHrs);
            this.grpSuiviRetour.Enabled = false;
            this.grpSuiviRetour.Location = new System.Drawing.Point(636, 201);
            this.grpSuiviRetour.Name = "grpSuiviRetour";
            this.grpSuiviRetour.Size = new System.Drawing.Size(583, 167);
            this.grpSuiviRetour.TabIndex = 60;
            this.grpSuiviRetour.TabStop = false;
            this.grpSuiviRetour.Text = "Retour";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(152, 72);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(27, 24);
            this.label62.TabIndex = 47;
            this.label62.Text = " : ";
            // 
            // dtpSuiviDateRetourDonneDemandeur
            // 
            this.dtpSuiviDateRetourDonneDemandeur.Location = new System.Drawing.Point(88, 49);
            this.dtpSuiviDateRetourDonneDemandeur.Name = "dtpSuiviDateRetourDonneDemandeur";
            this.dtpSuiviDateRetourDonneDemandeur.Size = new System.Drawing.Size(219, 20);
            this.dtpSuiviDateRetourDonneDemandeur.TabIndex = 46;
            // 
            // cbSuiviRetourPar
            // 
            this.cbSuiviRetourPar.FormattingEnabled = true;
            this.cbSuiviRetourPar.Items.AddRange(new object[] {
            "Lessard",
            "Gosselin",
            "Loiselle",
            "Pinard",
            "Monger",
            "Gaudreau",
            "Yergeau",
            "Brouillard",
            "Brousseau",
            "Desjardins"});
            this.cbSuiviRetourPar.Location = new System.Drawing.Point(88, 22);
            this.cbSuiviRetourPar.Name = "cbSuiviRetourPar";
            this.cbSuiviRetourPar.Size = new System.Drawing.Size(219, 21);
            this.cbSuiviRetourPar.TabIndex = 45;
            // 
            // tbSuiviRetourMin
            // 
            this.tbSuiviRetourMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuiviRetourMin.Location = new System.Drawing.Point(185, 74);
            this.tbSuiviRetourMin.Name = "tbSuiviRetourMin";
            this.tbSuiviRetourMin.Size = new System.Drawing.Size(76, 26);
            this.tbSuiviRetourMin.TabIndex = 29;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 118);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(77, 13);
            this.label58.TabIndex = 28;
            this.label58.Text = "Moyen utilisé : ";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 24);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(32, 13);
            this.label55.TabIndex = 7;
            this.label55.Text = "Par : ";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 55);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(39, 13);
            this.label56.TabIndex = 1;
            this.label56.Text = "Date : ";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 87);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(45, 13);
            this.label57.TabIndex = 2;
            this.label57.Text = "Heure : ";
            // 
            // tbSuiviRetourMoyen
            // 
            this.tbSuiviRetourMoyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuiviRetourMoyen.Location = new System.Drawing.Point(88, 110);
            this.tbSuiviRetourMoyen.Name = "tbSuiviRetourMoyen";
            this.tbSuiviRetourMoyen.Size = new System.Drawing.Size(230, 26);
            this.tbSuiviRetourMoyen.TabIndex = 25;
            // 
            // tbSuiviRetourHrs
            // 
            this.tbSuiviRetourHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuiviRetourHrs.Location = new System.Drawing.Point(88, 74);
            this.tbSuiviRetourHrs.Name = "tbSuiviRetourHrs";
            this.tbSuiviRetourHrs.Size = new System.Drawing.Size(58, 26);
            this.tbSuiviRetourHrs.TabIndex = 24;
            // 
            // cbSuiviPARL
            // 
            this.cbSuiviPARL.AutoSize = true;
            this.cbSuiviPARL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuiviPARL.Location = new System.Drawing.Point(636, 379);
            this.cbSuiviPARL.Name = "cbSuiviPARL";
            this.cbSuiviPARL.Size = new System.Drawing.Size(66, 20);
            this.cbSuiviPARL.TabIndex = 61;
            this.cbSuiviPARL.Text = "PARL";
            this.cbSuiviPARL.UseVisualStyleBackColor = true;
            this.cbSuiviPARL.CheckedChanged += new System.EventHandler(this.cbSuiviPARL_CheckedChanged);
            // 
            // cbSuiviRetour
            // 
            this.cbSuiviRetour.AutoSize = true;
            this.cbSuiviRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuiviRetour.Location = new System.Drawing.Point(636, 168);
            this.cbSuiviRetour.Name = "cbSuiviRetour";
            this.cbSuiviRetour.Size = new System.Drawing.Size(223, 20);
            this.cbSuiviRetour.TabIndex = 59;
            this.cbSuiviRetour.Text = "Retour donné au demandeur";
            this.cbSuiviRetour.UseVisualStyleBackColor = true;
            this.cbSuiviRetour.CheckedChanged += new System.EventHandler(this.cbSuiviRetour_CheckedChanged);
            // 
            // gbSuiviSurveillance
            // 
            this.gbSuiviSurveillance.Controls.Add(this.rtbSuiviCommentaires);
            this.gbSuiviSurveillance.Controls.Add(this.rbSuiviSurvNeg);
            this.gbSuiviSurveillance.Controls.Add(this.rbSuiviSurvPos);
            this.gbSuiviSurveillance.Controls.Add(this.label68);
            this.gbSuiviSurveillance.Controls.Add(this.tbSuiviDureeTotalSurveillance);
            this.gbSuiviSurveillance.Controls.Add(this.label69);
            this.gbSuiviSurveillance.Controls.Add(this.label70);
            this.gbSuiviSurveillance.Controls.Add(this.tbSuiviNbConstatsEmis);
            this.gbSuiviSurveillance.Controls.Add(this.tbSuiviNbPoliciersParticipants);
            this.gbSuiviSurveillance.Controls.Add(this.label71);
            this.gbSuiviSurveillance.Enabled = false;
            this.gbSuiviSurveillance.Location = new System.Drawing.Point(7, 192);
            this.gbSuiviSurveillance.Name = "gbSuiviSurveillance";
            this.gbSuiviSurveillance.Size = new System.Drawing.Size(583, 373);
            this.gbSuiviSurveillance.TabIndex = 58;
            this.gbSuiviSurveillance.TabStop = false;
            this.gbSuiviSurveillance.Text = "Surveillance";
            // 
            // rtbSuiviCommentaires
            // 
            this.rtbSuiviCommentaires.Location = new System.Drawing.Point(20, 197);
            this.rtbSuiviCommentaires.Name = "rtbSuiviCommentaires";
            this.rtbSuiviCommentaires.Size = new System.Drawing.Size(542, 155);
            this.rtbSuiviCommentaires.TabIndex = 30;
            this.rtbSuiviCommentaires.Text = "";
            // 
            // rbSuiviSurvNeg
            // 
            this.rbSuiviSurvNeg.AutoSize = true;
            this.rbSuiviSurvNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuiviSurvNeg.Location = new System.Drawing.Point(9, 150);
            this.rbSuiviSurvNeg.Name = "rbSuiviSurvNeg";
            this.rbSuiviSurvNeg.Size = new System.Drawing.Size(148, 17);
            this.rbSuiviSurvNeg.TabIndex = 29;
            this.rbSuiviSurvNeg.TabStop = true;
            this.rbSuiviSurvNeg.Text = "Surveillance négative";
            this.rbSuiviSurvNeg.UseVisualStyleBackColor = true;
            // 
            // rbSuiviSurvPos
            // 
            this.rbSuiviSurvPos.AutoSize = true;
            this.rbSuiviSurvPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuiviSurvPos.Location = new System.Drawing.Point(9, 126);
            this.rbSuiviSurvPos.Name = "rbSuiviSurvPos";
            this.rbSuiviSurvPos.Size = new System.Drawing.Size(311, 17);
            this.rbSuiviSurvPos.TabIndex = 28;
            this.rbSuiviSurvPos.TabStop = true;
            this.rbSuiviSurvPos.Text = "Surveillance positive ( transmis équipe concernée)";
            this.rbSuiviSurvPos.UseVisualStyleBackColor = true;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 24);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(217, 13);
            this.label68.TabIndex = 7;
            this.label68.Text = "Durée totale de la surveillance (heure/jour) : ";
            // 
            // tbSuiviDureeTotalSurveillance
            // 
            this.tbSuiviDureeTotalSurveillance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuiviDureeTotalSurveillance.Location = new System.Drawing.Point(229, 16);
            this.tbSuiviDureeTotalSurveillance.Name = "tbSuiviDureeTotalSurveillance";
            this.tbSuiviDureeTotalSurveillance.Size = new System.Drawing.Size(230, 26);
            this.tbSuiviDureeTotalSurveillance.TabIndex = 27;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 55);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(135, 13);
            this.label69.TabIndex = 1;
            this.label69.Text = "Nombre de constats émis : ";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(6, 87);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(166, 13);
            this.label70.TabIndex = 2;
            this.label70.Text = "Nombre de policiers participants : ";
            // 
            // tbSuiviNbConstatsEmis
            // 
            this.tbSuiviNbConstatsEmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuiviNbConstatsEmis.Location = new System.Drawing.Point(229, 46);
            this.tbSuiviNbConstatsEmis.Name = "tbSuiviNbConstatsEmis";
            this.tbSuiviNbConstatsEmis.Size = new System.Drawing.Size(230, 26);
            this.tbSuiviNbConstatsEmis.TabIndex = 25;
            // 
            // tbSuiviNbPoliciersParticipants
            // 
            this.tbSuiviNbPoliciersParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuiviNbPoliciersParticipants.Location = new System.Drawing.Point(229, 78);
            this.tbSuiviNbPoliciersParticipants.Name = "tbSuiviNbPoliciersParticipants";
            this.tbSuiviNbPoliciersParticipants.Size = new System.Drawing.Size(230, 26);
            this.tbSuiviNbPoliciersParticipants.TabIndex = 24;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(17, 181);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(82, 13);
            this.label71.TabIndex = 9;
            this.label71.Text = "Commentaires : ";
            // 
            // cbSuiviPatrouilleurAssigne
            // 
            this.cbSuiviPatrouilleurAssigne.FormattingEnabled = true;
            this.cbSuiviPatrouilleurAssigne.Items.AddRange(new object[] {
            "Lessard",
            "Gosselin",
            "Loiselle",
            "Pinard",
            "Monger",
            "Gaudreau",
            "Yergeau",
            "Brouillard",
            "Brousseau",
            "Desjardins"});
            this.cbSuiviPatrouilleurAssigne.Location = new System.Drawing.Point(169, 60);
            this.cbSuiviPatrouilleurAssigne.Name = "cbSuiviPatrouilleurAssigne";
            this.cbSuiviPatrouilleurAssigne.Size = new System.Drawing.Size(219, 21);
            this.cbSuiviPatrouilleurAssigne.TabIndex = 57;
            // 
            // cbSuiviVerifInfraLieux
            // 
            this.cbSuiviVerifInfraLieux.AutoSize = true;
            this.cbSuiviVerifInfraLieux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuiviVerifInfraLieux.Location = new System.Drawing.Point(7, 159);
            this.cbSuiviVerifInfraLieux.Name = "cbSuiviVerifInfraLieux";
            this.cbSuiviVerifInfraLieux.Size = new System.Drawing.Size(376, 20);
            this.cbSuiviVerifInfraLieux.TabIndex = 56;
            this.cbSuiviVerifInfraLieux.Text = "Verification de l\'infrastructure des lieux (au besoin)";
            this.cbSuiviVerifInfraLieux.UseVisualStyleBackColor = true;
            this.cbSuiviVerifInfraLieux.CheckedChanged += new System.EventHandler(this.cbSuiviVerifLieu_CheckedChanged);
            // 
            // tbSuiviNoDemande
            // 
            this.tbSuiviNoDemande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuiviNoDemande.Location = new System.Drawing.Point(169, 12);
            this.tbSuiviNoDemande.Name = "tbSuiviNoDemande";
            this.tbSuiviNoDemande.Size = new System.Drawing.Size(148, 26);
            this.tbSuiviNoDemande.TabIndex = 55;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(3, 15);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(149, 20);
            this.label67.TabIndex = 54;
            this.label67.Text = "Demande numéro : ";
            // 
            // dtpSuiviDateAgenda
            // 
            this.dtpSuiviDateAgenda.Location = new System.Drawing.Point(169, 95);
            this.dtpSuiviDateAgenda.Name = "dtpSuiviDateAgenda";
            this.dtpSuiviDateAgenda.Size = new System.Drawing.Size(219, 20);
            this.dtpSuiviDateAgenda.TabIndex = 64;
            // 
            // gbSuiviParl
            // 
            this.gbSuiviParl.Controls.Add(this.cbSuiviContolePar);
            this.gbSuiviParl.Controls.Add(this.label72);
            this.gbSuiviParl.Controls.Add(this.cbSuiviAlimentePar);
            this.gbSuiviParl.Controls.Add(this.label74);
            this.gbSuiviParl.Enabled = false;
            this.gbSuiviParl.Location = new System.Drawing.Point(642, 398);
            this.gbSuiviParl.Name = "gbSuiviParl";
            this.gbSuiviParl.Size = new System.Drawing.Size(583, 167);
            this.gbSuiviParl.TabIndex = 62;
            this.gbSuiviParl.TabStop = false;
            this.gbSuiviParl.Text = "PARL";
            // 
            // cbSuiviContolePar
            // 
            this.cbSuiviContolePar.FormattingEnabled = true;
            this.cbSuiviContolePar.Items.AddRange(new object[] {
            "Lessard",
            "Gosselin",
            "Loiselle",
            "Pinard",
            "Monger",
            "Gaudreau",
            "Yergeau",
            "Brouillard",
            "Brousseau",
            "Desjardins"});
            this.cbSuiviContolePar.Location = new System.Drawing.Point(88, 61);
            this.cbSuiviContolePar.Name = "cbSuiviContolePar";
            this.cbSuiviContolePar.Size = new System.Drawing.Size(219, 21);
            this.cbSuiviContolePar.TabIndex = 47;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(6, 63);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(73, 13);
            this.label72.TabIndex = 46;
            this.label72.Text = "Contrôlé par : ";
            // 
            // cbSuiviAlimentePar
            // 
            this.cbSuiviAlimentePar.FormattingEnabled = true;
            this.cbSuiviAlimentePar.Items.AddRange(new object[] {
            "Lessard",
            "Gosselin",
            "Loiselle",
            "Pinard",
            "Monger",
            "Gaudreau",
            "Yergeau",
            "Brouillard",
            "Brousseau",
            "Desjardins"});
            this.cbSuiviAlimentePar.Location = new System.Drawing.Point(88, 22);
            this.cbSuiviAlimentePar.Name = "cbSuiviAlimentePar";
            this.cbSuiviAlimentePar.Size = new System.Drawing.Size(219, 21);
            this.cbSuiviAlimentePar.TabIndex = 45;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(6, 24);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(74, 13);
            this.label74.TabIndex = 7;
            this.label74.Text = "Alimenté par : ";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(4, 95);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(123, 13);
            this.label66.TabIndex = 53;
            this.label66.Text = "Date d\'agenda (2 sem.): ";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(4, 63);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(107, 13);
            this.label64.TabIndex = 52;
            this.label64.Text = "Patrouilleur assigné : ";
            // 
            // tabFormulaire
            // 
            this.tabFormulaire.AutoScroll = true;
            this.tabFormulaire.Controls.Add(this.tcFormulaires);
            this.tabFormulaire.Location = new System.Drawing.Point(4, 54);
            this.tabFormulaire.Name = "tabFormulaire";
            this.tabFormulaire.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormulaire.Size = new System.Drawing.Size(1443, 594);
            this.tabFormulaire.TabIndex = 1;
            this.tabFormulaire.Text = "Formulaires";
            this.tabFormulaire.UseVisualStyleBackColor = true;
            // 
            // tcFormulaires
            // 
            this.tcFormulaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcFormulaires.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcFormulaires.Controls.Add(this.tabPlanif);
            this.tcFormulaires.Controls.Add(this.tabPlanEquipe);
            this.tcFormulaires.Controls.Add(this.tabRapportQuot);
            this.tcFormulaires.Controls.Add(this.cboReqPlaintePriseNom);
            this.tcFormulaires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcFormulaires.Location = new System.Drawing.Point(3, 0);
            this.tcFormulaires.Name = "tcFormulaires";
            this.tcFormulaires.SelectedIndex = 0;
            this.tcFormulaires.Size = new System.Drawing.Size(1432, 590);
            this.tcFormulaires.TabIndex = 0;
            // 
            // tabPlanif
            // 
            this.tabPlanif.AutoScroll = true;
            this.tabPlanif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPlanif.Controls.Add(this.bEnregistrerPlanif);
            this.tabPlanif.Controls.Add(this.bRechercherPlanif);
            this.tabPlanif.Controls.Add(this.cbAnneePlanif);
            this.tabPlanif.Controls.Add(this.cbMoisPlanif);
            this.tabPlanif.Controls.Add(this.label16);
            this.tabPlanif.Controls.Add(this.label9);
            this.tabPlanif.Controls.Add(this.tbThemePlanif);
            this.tabPlanif.Controls.Add(this.lTheme);
            this.tabPlanif.Controls.Add(this.tlpPlanifMensuelle);
            this.tabPlanif.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPlanif.Location = new System.Drawing.Point(4, 25);
            this.tabPlanif.Name = "tabPlanif";
            this.tabPlanif.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanif.Size = new System.Drawing.Size(1424, 561);
            this.tabPlanif.TabIndex = 0;
            this.tabPlanif.Text = "Planification Mensuelle";
            this.tabPlanif.UseVisualStyleBackColor = true;
            // 
            // bEnregistrerPlanif
            // 
            this.bEnregistrerPlanif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEnregistrerPlanif.Location = new System.Drawing.Point(1212, 6);
            this.bEnregistrerPlanif.Name = "bEnregistrerPlanif";
            this.bEnregistrerPlanif.Size = new System.Drawing.Size(112, 21);
            this.bEnregistrerPlanif.TabIndex = 8;
            this.bEnregistrerPlanif.Text = "Enregistrer";
            this.bEnregistrerPlanif.UseVisualStyleBackColor = true;
            // 
            // bRechercherPlanif
            // 
            this.bRechercherPlanif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRechercherPlanif.Location = new System.Drawing.Point(1085, 6);
            this.bRechercherPlanif.Name = "bRechercherPlanif";
            this.bRechercherPlanif.Size = new System.Drawing.Size(112, 20);
            this.bRechercherPlanif.TabIndex = 7;
            this.bRechercherPlanif.Text = "Rechercher";
            this.bRechercherPlanif.UseVisualStyleBackColor = true;
            this.bRechercherPlanif.Click += new System.EventHandler(this.bRechercherPlanif_Click);
            // 
            // cbAnneePlanif
            // 
            this.cbAnneePlanif.FormattingEnabled = true;
            this.cbAnneePlanif.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cbAnneePlanif.Location = new System.Drawing.Point(534, 7);
            this.cbAnneePlanif.Name = "cbAnneePlanif";
            this.cbAnneePlanif.Size = new System.Drawing.Size(121, 21);
            this.cbAnneePlanif.TabIndex = 6;
            // 
            // cbMoisPlanif
            // 
            this.cbMoisPlanif.FormattingEnabled = true;
            this.cbMoisPlanif.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Novembre",
            "Décembre"});
            this.cbMoisPlanif.Location = new System.Drawing.Point(350, 6);
            this.cbMoisPlanif.Name = "cbMoisPlanif";
            this.cbMoisPlanif.Size = new System.Drawing.Size(121, 21);
            this.cbMoisPlanif.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(488, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Année:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mois:";
            // 
            // tbThemePlanif
            // 
            this.tbThemePlanif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThemePlanif.Location = new System.Drawing.Point(58, 6);
            this.tbThemePlanif.Name = "tbThemePlanif";
            this.tbThemePlanif.Size = new System.Drawing.Size(211, 20);
            this.tbThemePlanif.TabIndex = 2;
            // 
            // lTheme
            // 
            this.lTheme.AutoSize = true;
            this.lTheme.Location = new System.Drawing.Point(9, 11);
            this.lTheme.Name = "lTheme";
            this.lTheme.Size = new System.Drawing.Size(43, 13);
            this.lTheme.TabIndex = 1;
            this.lTheme.Text = "Thème:";
            // 
            // tlpPlanifMensuelle
            // 
            this.tlpPlanifMensuelle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlpPlanifMensuelle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpPlanifMensuelle.ColumnCount = 6;
            this.tlpPlanifMensuelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.05047F));
            this.tlpPlanifMensuelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.40271F));
            this.tlpPlanifMensuelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.72659F));
            this.tlpPlanifMensuelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.72659F));
            this.tlpPlanifMensuelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.72659F));
            this.tlpPlanifMensuelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.367045F));
            this.tlpPlanifMensuelle.Controls.Add(this.label4, 2, 0);
            this.tlpPlanifMensuelle.Controls.Add(this.label3, 1, 0);
            this.tlpPlanifMensuelle.Controls.Add(this.label6, 4, 0);
            this.tlpPlanifMensuelle.Controls.Add(this.label7, 4, 1);
            this.tlpPlanifMensuelle.Controls.Add(this.label8, 5, 1);
            this.tlpPlanifMensuelle.Controls.Add(this.label10, 0, 2);
            this.tlpPlanifMensuelle.Controls.Add(this.label11, 0, 3);
            this.tlpPlanifMensuelle.Controls.Add(this.label12, 0, 4);
            this.tlpPlanifMensuelle.Controls.Add(this.label13, 0, 5);
            this.tlpPlanifMensuelle.Controls.Add(this.label14, 0, 6);
            this.tlpPlanifMensuelle.Controls.Add(this.label5, 3, 0);
            this.tlpPlanifMensuelle.Controls.Add(this.label15, 0, 7);
            this.tlpPlanifMensuelle.Controls.Add(this.label1, 0, 0);
            this.tlpPlanifMensuelle.Location = new System.Drawing.Point(7, 39);
            this.tlpPlanifMensuelle.Name = "tlpPlanifMensuelle";
            this.tlpPlanifMensuelle.RowCount = 8;
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.032444F));
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.89239F));
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.51745F));
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.51745F));
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.4879F));
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.51745F));
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.51745F));
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.51745F));
            this.tlpPlanifMensuelle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlanifMensuelle.Size = new System.Drawing.Size(1402, 503);
            this.tlpPlanifMensuelle.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.tlpPlanifMensuelle.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(261, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "ENDROITS CIBLÉS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.tlpPlanifMensuelle.SetRowSpan(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(312, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "SITUATION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPlanifMensuelle.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1048, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "RÉSULTATS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1048, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "ATTENDUS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1310, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "OBTENUS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 56);
            this.label10.TabIndex = 7;
            this.label10.Text = "Visibilité";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 56);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sécurité du milieu de vie";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 170);
            this.label12.TabIndex = 9;
            this.label12.Text = "Sécurité des réseaux de transports";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 326);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 56);
            this.label13.TabIndex = 10;
            this.label13.Text = "Lutte contre le crime";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1, 383);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 56);
            this.label14.TabIndex = 11;
            this.label14.Text = "Drogues, alcools, moralité et jeux";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(786, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.tlpPlanifMensuelle.SetRowSpan(this.label5, 2);
            this.label5.Size = new System.Drawing.Size(261, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "ACTIONS PRÉVUES";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 440);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 62);
            this.label15.TabIndex = 12;
            this.label15.Text = "Divers";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.tlpPlanifMensuelle.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOMAINES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPlanEquipe
            // 
            this.tabPlanEquipe.AutoScroll = true;
            this.tabPlanEquipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPlanEquipe.Controls.Add(this.btnEnregistrerPlan);
            this.tabPlanEquipe.Controls.Add(this.btnRechercherPlan);
            this.tabPlanEquipe.Controls.Add(this.cboPlanifAnne);
            this.tabPlanEquipe.Controls.Add(this.cboPlanifMois);
            this.tabPlanEquipe.Controls.Add(this.cboPlanifEquipe);
            this.tabPlanEquipe.Controls.Add(this.label28);
            this.tabPlanEquipe.Controls.Add(this.label27);
            this.tabPlanEquipe.Controls.Add(this.label26);
            this.tabPlanEquipe.Controls.Add(this.tlpPlanTravail);
            this.tabPlanEquipe.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPlanEquipe.Location = new System.Drawing.Point(4, 25);
            this.tabPlanEquipe.Name = "tabPlanEquipe";
            this.tabPlanEquipe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanEquipe.Size = new System.Drawing.Size(1424, 561);
            this.tabPlanEquipe.TabIndex = 1;
            this.tabPlanEquipe.Text = "Plan de travail d\'équipe";
            this.tabPlanEquipe.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerPlan
            // 
            this.btnEnregistrerPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerPlan.Location = new System.Drawing.Point(1303, 5);
            this.btnEnregistrerPlan.Name = "btnEnregistrerPlan";
            this.btnEnregistrerPlan.Size = new System.Drawing.Size(96, 28);
            this.btnEnregistrerPlan.TabIndex = 9;
            this.btnEnregistrerPlan.Text = "Enregistrer";
            this.btnEnregistrerPlan.UseVisualStyleBackColor = true;
            // 
            // btnRechercherPlan
            // 
            this.btnRechercherPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercherPlan.Location = new System.Drawing.Point(1189, 5);
            this.btnRechercherPlan.Name = "btnRechercherPlan";
            this.btnRechercherPlan.Size = new System.Drawing.Size(96, 28);
            this.btnRechercherPlan.TabIndex = 8;
            this.btnRechercherPlan.Text = "Rechercher";
            this.btnRechercherPlan.UseVisualStyleBackColor = true;
            this.btnRechercherPlan.Click += new System.EventHandler(this.btnRechercherPlan_Click);
            // 
            // cboPlanifAnne
            // 
            this.cboPlanifAnne.FormattingEnabled = true;
            this.cboPlanifAnne.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cboPlanifAnne.Location = new System.Drawing.Point(492, 7);
            this.cboPlanifAnne.Name = "cboPlanifAnne";
            this.cboPlanifAnne.Size = new System.Drawing.Size(121, 21);
            this.cboPlanifAnne.TabIndex = 6;
            // 
            // cboPlanifMois
            // 
            this.cboPlanifMois.FormattingEnabled = true;
            this.cboPlanifMois.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Novembre",
            "Décembre"});
            this.cboPlanifMois.Location = new System.Drawing.Point(287, 7);
            this.cboPlanifMois.Name = "cboPlanifMois";
            this.cboPlanifMois.Size = new System.Drawing.Size(121, 21);
            this.cboPlanifMois.TabIndex = 5;
            // 
            // cboPlanifEquipe
            // 
            this.cboPlanifEquipe.FormattingEnabled = true;
            this.cboPlanifEquipe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "PAHV",
            "Multi"});
            this.cboPlanifEquipe.Location = new System.Drawing.Point(72, 5);
            this.cboPlanifEquipe.Name = "cboPlanifEquipe";
            this.cboPlanifEquipe.Size = new System.Drawing.Size(121, 21);
            this.cboPlanifEquipe.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(439, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 14);
            this.label28.TabIndex = 3;
            this.label28.Text = "ANNÉE:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(239, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 14);
            this.label27.TabIndex = 2;
            this.label27.Text = "MOIS:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(8, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 14);
            this.label26.TabIndex = 1;
            this.label26.Text = "ÉQUIPE : ";
            // 
            // tlpPlanTravail
            // 
            this.tlpPlanTravail.BackColor = System.Drawing.SystemColors.Window;
            this.tlpPlanTravail.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpPlanTravail.ColumnCount = 21;
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.524969F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.524969F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.238091F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.235889F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.236131F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.236131F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.240138F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.240138F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.523617F));
            this.tlpPlanTravail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.240138F));
            this.tlpPlanTravail.Controls.Add(this.label19, 0, 0);
            this.tlpPlanTravail.Controls.Add(this.label20, 3, 0);
            this.tlpPlanTravail.Controls.Add(this.label21, 6, 0);
            this.tlpPlanTravail.Controls.Add(this.label22, 9, 0);
            this.tlpPlanTravail.Controls.Add(this.label23, 12, 0);
            this.tlpPlanTravail.Controls.Add(this.label24, 15, 0);
            this.tlpPlanTravail.Controls.Add(this.label25, 18, 0);
            this.tlpPlanTravail.Location = new System.Drawing.Point(11, 39);
            this.tlpPlanTravail.Name = "tlpPlanTravail";
            this.tlpPlanTravail.RowCount = 11;
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.911262F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.572702F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64505F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.572702F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64505F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.572702F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64505F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.572702F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64505F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.572702F));
            this.tlpPlanTravail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64505F));
            this.tlpPlanTravail.Size = new System.Drawing.Size(1407, 516);
            this.tlpPlanTravail.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPlanTravail.SetColumnSpan(this.label19, 3);
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(2, 2);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "DIMANCHE";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPlanTravail.SetColumnSpan(this.label20, 3);
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(201, 2);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(197, 19);
            this.label20.TabIndex = 3;
            this.label20.Text = "LUNDI";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPlanTravail.SetColumnSpan(this.label21, 3);
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(400, 2);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(197, 19);
            this.label21.TabIndex = 4;
            this.label21.Text = "MARDI";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPlanTravail.SetColumnSpan(this.label22, 3);
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(599, 2);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(197, 19);
            this.label22.TabIndex = 5;
            this.label22.Text = "MERCREDI";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPlanTravail.SetColumnSpan(this.label23, 3);
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(798, 2);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(197, 19);
            this.label23.TabIndex = 6;
            this.label23.Text = "JEUDI";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPlanTravail.SetColumnSpan(this.label24, 3);
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(997, 2);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(197, 19);
            this.label24.TabIndex = 7;
            this.label24.Text = "VENDREDI";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPlanTravail.SetColumnSpan(this.label25, 3);
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(1196, 2);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(209, 19);
            this.label25.TabIndex = 8;
            this.label25.Text = "SAMEDI";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabRapportQuot
            // 
            this.tabRapportQuot.Controls.Add(this.bRapQuotVersRequ);
            this.tabRapportQuot.Controls.Add(this.bRapQuotVersSuiviRequ);
            this.tabRapportQuot.Controls.Add(this.bRapQuotVersActionsRequ);
            this.tabRapportQuot.Controls.Add(this.dgvRapQuot);
            this.tabRapportQuot.Controls.Add(this.bRechercherRapQuot);
            this.tabRapportQuot.Controls.Add(this.bEnregistrerRapQuot);
            this.tabRapportQuot.Controls.Add(this.tableLayoutPanel2);
            this.tabRapportQuot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabRapportQuot.Location = new System.Drawing.Point(4, 25);
            this.tabRapportQuot.Name = "tabRapportQuot";
            this.tabRapportQuot.Size = new System.Drawing.Size(1424, 561);
            this.tabRapportQuot.TabIndex = 2;
            this.tabRapportQuot.Text = "Rapport Quotidien";
            this.tabRapportQuot.UseVisualStyleBackColor = true;
            // 
            // bRapQuotVersRequ
            // 
            this.bRapQuotVersRequ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRapQuotVersRequ.Enabled = false;
            this.bRapQuotVersRequ.Location = new System.Drawing.Point(917, 531);
            this.bRapQuotVersRequ.Name = "bRapQuotVersRequ";
            this.bRapQuotVersRequ.Size = new System.Drawing.Size(164, 23);
            this.bRapQuotVersRequ.TabIndex = 8;
            this.bRapQuotVersRequ.Text = "Voir la requête";
            this.bRapQuotVersRequ.UseVisualStyleBackColor = true;
            this.bRapQuotVersRequ.Click += new System.EventHandler(this.VersRequete_Click);
            // 
            // bRapQuotVersSuiviRequ
            // 
            this.bRapQuotVersSuiviRequ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRapQuotVersSuiviRequ.Enabled = false;
            this.bRapQuotVersSuiviRequ.Location = new System.Drawing.Point(1087, 531);
            this.bRapQuotVersSuiviRequ.Name = "bRapQuotVersSuiviRequ";
            this.bRapQuotVersSuiviRequ.Size = new System.Drawing.Size(164, 23);
            this.bRapQuotVersSuiviRequ.TabIndex = 7;
            this.bRapQuotVersSuiviRequ.Text = "Voir le suivi de la requête";
            this.bRapQuotVersSuiviRequ.UseVisualStyleBackColor = true;
            this.bRapQuotVersSuiviRequ.Click += new System.EventHandler(this.VersSuiviRequ_Click);
            // 
            // bRapQuotVersActionsRequ
            // 
            this.bRapQuotVersActionsRequ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRapQuotVersActionsRequ.Enabled = false;
            this.bRapQuotVersActionsRequ.Location = new System.Drawing.Point(1257, 531);
            this.bRapQuotVersActionsRequ.Name = "bRapQuotVersActionsRequ";
            this.bRapQuotVersActionsRequ.Size = new System.Drawing.Size(164, 23);
            this.bRapQuotVersActionsRequ.TabIndex = 6;
            this.bRapQuotVersActionsRequ.Text = "Voir les actions de la requête";
            this.bRapQuotVersActionsRequ.UseVisualStyleBackColor = true;
            this.bRapQuotVersActionsRequ.Click += new System.EventHandler(this.VersActionsRequ_Click);
            // 
            // dgvRapQuot
            // 
            this.dgvRapQuot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRapQuot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapQuot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatriculeRapQuot,
            this.PatrouilleurRapQuot,
            this.SecteurRapQuot,
            this.VehiculeRapQuot,
            this.AssignationRapQuot,
            this.FaitRapQuot});
            this.dgvRapQuot.Location = new System.Drawing.Point(11, 100);
            this.dgvRapQuot.MultiSelect = false;
            this.dgvRapQuot.Name = "dgvRapQuot";
            this.dgvRapQuot.Size = new System.Drawing.Size(1410, 425);
            this.dgvRapQuot.TabIndex = 3;
            this.dgvRapQuot.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.HandleEditShowing);
            this.dgvRapQuot.SelectionChanged += new System.EventHandler(this.dgvRapQuot_SelectionChanged);
            // 
            // MatriculeRapQuot
            // 
            this.MatriculeRapQuot.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MatriculeRapQuot.HeaderText = "Matricule";
            this.MatriculeRapQuot.Items.AddRange(new object[] {
            "1144",
            "1653",
            "1651",
            "1756",
            "3216",
            "1613",
            "1651"});
            this.MatriculeRapQuot.Name = "MatriculeRapQuot";
            this.MatriculeRapQuot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MatriculeRapQuot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MatriculeRapQuot.Width = 75;
            // 
            // PatrouilleurRapQuot
            // 
            this.PatrouilleurRapQuot.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PatrouilleurRapQuot.HeaderText = "Patrouilleur";
            this.PatrouilleurRapQuot.Items.AddRange(new object[] {
            "Simon",
            "Edward",
            "Benoît",
            "Stanley"});
            this.PatrouilleurRapQuot.Name = "PatrouilleurRapQuot";
            // 
            // SecteurRapQuot
            // 
            this.SecteurRapQuot.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.SecteurRapQuot.HeaderText = "Secteur";
            this.SecteurRapQuot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.SecteurRapQuot.Name = "SecteurRapQuot";
            this.SecteurRapQuot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SecteurRapQuot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SecteurRapQuot.Width = 60;
            // 
            // VehiculeRapQuot
            // 
            this.VehiculeRapQuot.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.VehiculeRapQuot.HeaderText = "Véhicule";
            this.VehiculeRapQuot.Items.AddRange(new object[] {
            "16516",
            "65165",
            "98431",
            "19846",
            "46544",
            "44845"});
            this.VehiculeRapQuot.Name = "VehiculeRapQuot";
            this.VehiculeRapQuot.Width = 75;
            // 
            // AssignationRapQuot
            // 
            this.AssignationRapQuot.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.AssignationRapQuot.HeaderText = "Assignation";
            this.AssignationRapQuot.Items.AddRange(new object[] {
            "Cinémomètre",
            "Patrouille près des bars",
            "Rapport"});
            this.AssignationRapQuot.Name = "AssignationRapQuot";
            this.AssignationRapQuot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssignationRapQuot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AssignationRapQuot.Width = 300;
            // 
            // FaitRapQuot
            // 
            this.FaitRapQuot.HeaderText = "Fait";
            this.FaitRapQuot.Name = "FaitRapQuot";
            this.FaitRapQuot.Width = 40;
            // 
            // bRechercherRapQuot
            // 
            this.bRechercherRapQuot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRechercherRapQuot.Location = new System.Drawing.Point(1195, 10);
            this.bRechercherRapQuot.Name = "bRechercherRapQuot";
            this.bRechercherRapQuot.Size = new System.Drawing.Size(110, 42);
            this.bRechercherRapQuot.TabIndex = 2;
            this.bRechercherRapQuot.Text = "Rechercher";
            this.bRechercherRapQuot.UseVisualStyleBackColor = true;
            // 
            // bEnregistrerRapQuot
            // 
            this.bEnregistrerRapQuot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEnregistrerRapQuot.Location = new System.Drawing.Point(1311, 10);
            this.bEnregistrerRapQuot.Name = "bEnregistrerRapQuot";
            this.bEnregistrerRapQuot.Size = new System.Drawing.Size(110, 42);
            this.bEnregistrerRapQuot.TabIndex = 1;
            this.bEnregistrerRapQuot.Text = "Enregistrer";
            this.bEnregistrerRapQuot.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.3202F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.67979F));
            this.tableLayoutPanel2.Controls.Add(this.cbReleveRapQuot, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label54, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label53, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label52, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbEquipeRapQuot, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpRapQuot, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(353, 83);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbReleveRapQuot
            // 
            this.cbReleveRapQuot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbReleveRapQuot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbReleveRapQuot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReleveRapQuot.FormattingEnabled = true;
            this.cbReleveRapQuot.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbReleveRapQuot.Location = new System.Drawing.Point(118, 58);
            this.cbReleveRapQuot.Name = "cbReleveRapQuot";
            this.cbReleveRapQuot.Size = new System.Drawing.Size(231, 21);
            this.cbReleveRapQuot.TabIndex = 5;
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(4, 62);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 13);
            this.label54.TabIndex = 4;
            this.label54.Text = "Relève";
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(4, 34);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(43, 13);
            this.label53.TabIndex = 2;
            this.label53.Text = "Équipe:";
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(4, 7);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(33, 13);
            this.label52.TabIndex = 0;
            this.label52.Text = "Date:";
            // 
            // cbEquipeRapQuot
            // 
            this.cbEquipeRapQuot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbEquipeRapQuot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbEquipeRapQuot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEquipeRapQuot.FormattingEnabled = true;
            this.cbEquipeRapQuot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "PAHV",
            "Équipe-Multi"});
            this.cbEquipeRapQuot.Location = new System.Drawing.Point(118, 31);
            this.cbEquipeRapQuot.Name = "cbEquipeRapQuot";
            this.cbEquipeRapQuot.Size = new System.Drawing.Size(231, 21);
            this.cbEquipeRapQuot.TabIndex = 3;
            // 
            // dtpRapQuot
            // 
            this.dtpRapQuot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpRapQuot.Location = new System.Drawing.Point(118, 4);
            this.dtpRapQuot.Name = "dtpRapQuot";
            this.dtpRapQuot.Size = new System.Drawing.Size(231, 20);
            this.dtpRapQuot.TabIndex = 1;
            this.dtpRapQuot.ValueChanged += new System.EventHandler(this.dtpRapQuot_ValueChanged);
            // 
            // cboReqPlaintePriseNom
            // 
            this.cboReqPlaintePriseNom.AutoScroll = true;
            this.cboReqPlaintePriseNom.Controls.Add(this.dtpDateRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.bRechercherNoRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.label48);
            this.cboReqPlaintePriseNom.Controls.Add(this.label47);
            this.cboReqPlaintePriseNom.Controls.Add(this.tbDemandeRecuRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.label46);
            this.cboReqPlaintePriseNom.Controls.Add(this.tbPlaintePriseParRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.label45);
            this.cboReqPlaintePriseNom.Controls.Add(this.cbSuspectConnuRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.tlpSuspectConnuRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.groupBox2);
            this.cboReqPlaintePriseNom.Controls.Add(this.tbMunicipaliteRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.tbLocalisationRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.label37);
            this.cboReqPlaintePriseNom.Controls.Add(this.lLocalisationRequete);
            this.cboReqPlaintePriseNom.Controls.Add(this.bgDescriptionDemande);
            this.cboReqPlaintePriseNom.Controls.Add(this.tbRequeteCircAutres);
            this.cboReqPlaintePriseNom.Controls.Add(this.tableLayoutPanel3);
            this.cboReqPlaintePriseNom.Controls.Add(this.radioButton2);
            this.cboReqPlaintePriseNom.Controls.Add(this.radioButton1);
            this.cboReqPlaintePriseNom.Controls.Add(this.label35);
            this.cboReqPlaintePriseNom.Controls.Add(this.groupBox1);
            this.cboReqPlaintePriseNom.Controls.Add(this.textBox1);
            this.cboReqPlaintePriseNom.Controls.Add(this.label29);
            this.cboReqPlaintePriseNom.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboReqPlaintePriseNom.Location = new System.Drawing.Point(4, 25);
            this.cboReqPlaintePriseNom.Name = "cboReqPlaintePriseNom";
            this.cboReqPlaintePriseNom.Padding = new System.Windows.Forms.Padding(3);
            this.cboReqPlaintePriseNom.Size = new System.Drawing.Size(1424, 561);
            this.cboReqPlaintePriseNom.TabIndex = 3;
            this.cboReqPlaintePriseNom.Text = "Requête de circulation";
            this.cboReqPlaintePriseNom.UseVisualStyleBackColor = true;
            // 
            // dtpDateRequete
            // 
            this.dtpDateRequete.Location = new System.Drawing.Point(804, 403);
            this.dtpDateRequete.Name = "dtpDateRequete";
            this.dtpDateRequete.Size = new System.Drawing.Size(164, 20);
            this.dtpDateRequete.TabIndex = 36;
            // 
            // bRechercherNoRequete
            // 
            this.bRechercherNoRequete.Location = new System.Drawing.Point(264, 2);
            this.bRechercherNoRequete.Name = "bRechercherNoRequete";
            this.bRechercherNoRequete.Size = new System.Drawing.Size(202, 23);
            this.bRechercherNoRequete.TabIndex = 35;
            this.bRechercherNoRequete.Text = "Rechercher par numéro de requête";
            this.bRechercherNoRequete.UseVisualStyleBackColor = true;
            this.bRechercherNoRequete.Click += new System.EventHandler(this.bRechercherNoRequete_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(551, 451);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(415, 12);
            this.label48.TabIndex = 34;
            this.label48.Text = "(Inscrire la provenance de la demande ; ex: en personne, par la municipalité, par" +
    " téléphone, par fax...)";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(511, 432);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(80, 13);
            this.label47.TabIndex = 33;
            this.label47.Text = "Demande reçu:";
            // 
            // tbDemandeRecuRequete
            // 
            this.tbDemandeRecuRequete.Location = new System.Drawing.Point(804, 429);
            this.tbDemandeRecuRequete.Name = "tbDemandeRecuRequete";
            this.tbDemandeRecuRequete.Size = new System.Drawing.Size(164, 20);
            this.tbDemandeRecuRequete.TabIndex = 32;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(511, 406);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(33, 13);
            this.label46.TabIndex = 30;
            this.label46.Text = "Date:";
            // 
            // tbPlaintePriseParRequete
            // 
            this.tbPlaintePriseParRequete.Location = new System.Drawing.Point(804, 377);
            this.tbPlaintePriseParRequete.Name = "tbPlaintePriseParRequete";
            this.tbPlaintePriseParRequete.Size = new System.Drawing.Size(164, 20);
            this.tbPlaintePriseParRequete.TabIndex = 29;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(511, 380);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(85, 13);
            this.label45.TabIndex = 28;
            this.label45.Text = "Plainte prise par:";
            // 
            // cbSuspectConnuRequete
            // 
            this.cbSuspectConnuRequete.AutoSize = true;
            this.cbSuspectConnuRequete.Location = new System.Drawing.Point(514, 211);
            this.cbSuspectConnuRequete.Name = "cbSuspectConnuRequete";
            this.cbSuspectConnuRequete.Size = new System.Drawing.Size(71, 17);
            this.cbSuspectConnuRequete.TabIndex = 27;
            this.cbSuspectConnuRequete.Text = "Si connu:";
            this.cbSuspectConnuRequete.UseVisualStyleBackColor = true;
            this.cbSuspectConnuRequete.CheckedChanged += new System.EventHandler(this.cbSuspectConnuRequete_CheckedChanged);
            // 
            // tlpSuspectConnuRequete
            // 
            this.tlpSuspectConnuRequete.ColumnCount = 3;
            this.tlpSuspectConnuRequete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tlpSuspectConnuRequete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSuspectConnuRequete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSuspectConnuRequete.Controls.Add(this.tbDescPhysSuspect2Requete, 2, 4);
            this.tlpSuspectConnuRequete.Controls.Add(this.label41, 0, 4);
            this.tlpSuspectConnuRequete.Controls.Add(this.label40, 0, 3);
            this.tlpSuspectConnuRequete.Controls.Add(this.label39, 0, 2);
            this.tlpSuspectConnuRequete.Controls.Add(this.label38, 0, 1);
            this.tlpSuspectConnuRequete.Controls.Add(this.label42, 1, 0);
            this.tlpSuspectConnuRequete.Controls.Add(this.label43, 2, 0);
            this.tlpSuspectConnuRequete.Controls.Add(this.tbNomSuspect1Requete, 1, 1);
            this.tlpSuspectConnuRequete.Controls.Add(this.tbPrenomSuspect1Requete, 1, 2);
            this.tlpSuspectConnuRequete.Controls.Add(this.tbDateNaissanceSuspect1Requete, 1, 3);
            this.tlpSuspectConnuRequete.Controls.Add(this.tbDescPhysSuspect1Requete, 1, 4);
            this.tlpSuspectConnuRequete.Controls.Add(this.tbNomSuspect2Requete, 2, 1);
            this.tlpSuspectConnuRequete.Controls.Add(this.tbPrenomSuspect2Requete, 2, 2);
            this.tlpSuspectConnuRequete.Controls.Add(this.tbDateNaissanceSuspect2Requete, 2, 3);
            this.tlpSuspectConnuRequete.Controls.Add(this.label44, 0, 5);
            this.tlpSuspectConnuRequete.Controls.Add(this.tbContrevenantDemeureRequete, 2, 5);
            this.tlpSuspectConnuRequete.Enabled = false;
            this.tlpSuspectConnuRequete.Location = new System.Drawing.Point(508, 206);
            this.tlpSuspectConnuRequete.Name = "tlpSuspectConnuRequete";
            this.tlpSuspectConnuRequete.RowCount = 6;
            this.tlpSuspectConnuRequete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSuspectConnuRequete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSuspectConnuRequete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSuspectConnuRequete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSuspectConnuRequete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSuspectConnuRequete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSuspectConnuRequete.Size = new System.Drawing.Size(464, 147);
            this.tlpSuspectConnuRequete.TabIndex = 24;
            // 
            // tbDescPhysSuspect2Requete
            // 
            this.tbDescPhysSuspect2Requete.Location = new System.Drawing.Point(296, 99);
            this.tbDescPhysSuspect2Requete.Name = "tbDescPhysSuspect2Requete";
            this.tbDescPhysSuspect2Requete.Size = new System.Drawing.Size(164, 20);
            this.tbDescPhysSuspect2Requete.TabIndex = 22;
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 101);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(108, 13);
            this.label41.TabIndex = 12;
            this.label41.Text = "Description physique:";
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 77);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(99, 13);
            this.label40.TabIndex = 11;
            this.label40.Text = "Date de naissance:";
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 53);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 13);
            this.label39.TabIndex = 10;
            this.label39.Text = "Prénom:";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 29);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(32, 13);
            this.label38.TabIndex = 9;
            this.label38.Text = "Nom:";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(126, 5);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(62, 13);
            this.label42.TabIndex = 13;
            this.label42.Text = "Suspect #1";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(296, 5);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(62, 13);
            this.label43.TabIndex = 14;
            this.label43.Text = "Suspect #2";
            // 
            // tbNomSuspect1Requete
            // 
            this.tbNomSuspect1Requete.Location = new System.Drawing.Point(126, 27);
            this.tbNomSuspect1Requete.Name = "tbNomSuspect1Requete";
            this.tbNomSuspect1Requete.Size = new System.Drawing.Size(164, 20);
            this.tbNomSuspect1Requete.TabIndex = 15;
            // 
            // tbPrenomSuspect1Requete
            // 
            this.tbPrenomSuspect1Requete.Location = new System.Drawing.Point(126, 51);
            this.tbPrenomSuspect1Requete.Name = "tbPrenomSuspect1Requete";
            this.tbPrenomSuspect1Requete.Size = new System.Drawing.Size(164, 20);
            this.tbPrenomSuspect1Requete.TabIndex = 16;
            // 
            // tbDateNaissanceSuspect1Requete
            // 
            this.tbDateNaissanceSuspect1Requete.Location = new System.Drawing.Point(126, 75);
            this.tbDateNaissanceSuspect1Requete.Name = "tbDateNaissanceSuspect1Requete";
            this.tbDateNaissanceSuspect1Requete.Size = new System.Drawing.Size(164, 20);
            this.tbDateNaissanceSuspect1Requete.TabIndex = 17;
            // 
            // tbDescPhysSuspect1Requete
            // 
            this.tbDescPhysSuspect1Requete.Location = new System.Drawing.Point(126, 99);
            this.tbDescPhysSuspect1Requete.Name = "tbDescPhysSuspect1Requete";
            this.tbDescPhysSuspect1Requete.Size = new System.Drawing.Size(164, 20);
            this.tbDescPhysSuspect1Requete.TabIndex = 18;
            // 
            // tbNomSuspect2Requete
            // 
            this.tbNomSuspect2Requete.Location = new System.Drawing.Point(296, 27);
            this.tbNomSuspect2Requete.Name = "tbNomSuspect2Requete";
            this.tbNomSuspect2Requete.Size = new System.Drawing.Size(164, 20);
            this.tbNomSuspect2Requete.TabIndex = 19;
            // 
            // tbPrenomSuspect2Requete
            // 
            this.tbPrenomSuspect2Requete.Location = new System.Drawing.Point(296, 51);
            this.tbPrenomSuspect2Requete.Name = "tbPrenomSuspect2Requete";
            this.tbPrenomSuspect2Requete.Size = new System.Drawing.Size(164, 20);
            this.tbPrenomSuspect2Requete.TabIndex = 20;
            // 
            // tbDateNaissanceSuspect2Requete
            // 
            this.tbDateNaissanceSuspect2Requete.Location = new System.Drawing.Point(296, 75);
            this.tbDateNaissanceSuspect2Requete.Name = "tbDateNaissanceSuspect2Requete";
            this.tbDateNaissanceSuspect2Requete.Size = new System.Drawing.Size(164, 20);
            this.tbDateNaissanceSuspect2Requete.TabIndex = 21;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label44.AutoSize = true;
            this.tlpSuspectConnuRequete.SetColumnSpan(this.label44, 2);
            this.label44.Location = new System.Drawing.Point(3, 127);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(262, 13);
            this.label44.TabIndex = 25;
            this.label44.Text = "Le(s) contrevenant(s) demeure(nt)-il(s) dans le secteur:";
            // 
            // tbContrevenantDemeureRequete
            // 
            this.tbContrevenantDemeureRequete.Location = new System.Drawing.Point(296, 123);
            this.tbContrevenantDemeureRequete.Name = "tbContrevenantDemeureRequete";
            this.tbContrevenantDemeureRequete.Size = new System.Drawing.Size(164, 20);
            this.tbContrevenantDemeureRequete.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbDescriptionSuspectRequete);
            this.groupBox2.Location = new System.Drawing.Point(502, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 150);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description de ou des suspects";
            // 
            // rtbDescriptionSuspectRequete
            // 
            this.rtbDescriptionSuspectRequete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescriptionSuspectRequete.Location = new System.Drawing.Point(6, 19);
            this.rtbDescriptionSuspectRequete.Name = "rtbDescriptionSuspectRequete";
            this.rtbDescriptionSuspectRequete.Size = new System.Drawing.Size(458, 125);
            this.rtbDescriptionSuspectRequete.TabIndex = 22;
            this.rtbDescriptionSuspectRequete.Text = "";
            // 
            // tbMunicipaliteRequete
            // 
            this.tbMunicipaliteRequete.Location = new System.Drawing.Point(305, 543);
            this.tbMunicipaliteRequete.Name = "tbMunicipaliteRequete";
            this.tbMunicipaliteRequete.Size = new System.Drawing.Size(161, 20);
            this.tbMunicipaliteRequete.TabIndex = 20;
            // 
            // tbLocalisationRequete
            // 
            this.tbLocalisationRequete.Location = new System.Drawing.Point(17, 543);
            this.tbLocalisationRequete.Name = "tbLocalisationRequete";
            this.tbLocalisationRequete.Size = new System.Drawing.Size(161, 20);
            this.tbLocalisationRequete.TabIndex = 19;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(302, 527);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 13);
            this.label37.TabIndex = 18;
            this.label37.Text = "Municipalité:";
            // 
            // lLocalisationRequete
            // 
            this.lLocalisationRequete.AutoSize = true;
            this.lLocalisationRequete.Location = new System.Drawing.Point(14, 527);
            this.lLocalisationRequete.Name = "lLocalisationRequete";
            this.lLocalisationRequete.Size = new System.Drawing.Size(66, 13);
            this.lLocalisationRequete.TabIndex = 17;
            this.lLocalisationRequete.Text = "Localisation:";
            // 
            // bgDescriptionDemande
            // 
            this.bgDescriptionDemande.Controls.Add(this.rtbDescriptionDemande);
            this.bgDescriptionDemande.Location = new System.Drawing.Point(10, 338);
            this.bgDescriptionDemande.Name = "bgDescriptionDemande";
            this.bgDescriptionDemande.Size = new System.Drawing.Size(464, 179);
            this.bgDescriptionDemande.TabIndex = 16;
            this.bgDescriptionDemande.TabStop = false;
            this.bgDescriptionDemande.Text = "Description de la demande";
            // 
            // rtbDescriptionDemande
            // 
            this.rtbDescriptionDemande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescriptionDemande.Location = new System.Drawing.Point(7, 20);
            this.rtbDescriptionDemande.Name = "rtbDescriptionDemande";
            this.rtbDescriptionDemande.Size = new System.Drawing.Size(451, 153);
            this.rtbDescriptionDemande.TabIndex = 0;
            this.rtbDescriptionDemande.Text = "";
            // 
            // tbRequeteCircAutres
            // 
            this.tbRequeteCircAutres.Enabled = false;
            this.tbRequeteCircAutres.Location = new System.Drawing.Point(359, 308);
            this.tbRequeteCircAutres.Name = "tbRequeteCircAutres";
            this.tbRequeteCircAutres.Size = new System.Drawing.Size(110, 20);
            this.tbRequeteCircAutres.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.checkBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBox2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBox3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox5, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBox6, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBox7, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbRequeteCircAutres, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 231);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 100);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(113, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Vitesse excessive";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(290, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Signalisation non respectée";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(113, 28);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(105, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Véhicule bruyant";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(290, 28);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(171, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Véhicule stationné illégalement";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(113, 53);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(110, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Présence de VTT";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(290, 53);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(142, 17);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Camoin en zone interdite";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(113, 78);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(138, 17);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "Attroupement de jeunes";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // cbRequeteCircAutres
            // 
            this.cbRequeteCircAutres.AutoSize = true;
            this.cbRequeteCircAutres.Location = new System.Drawing.Point(290, 78);
            this.cbRequeteCircAutres.Name = "cbRequeteCircAutres";
            this.cbRequeteCircAutres.Size = new System.Drawing.Size(59, 17);
            this.cbRequeteCircAutres.TabIndex = 8;
            this.cbRequeteCircAutres.Text = "Autres:";
            this.cbRequeteCircAutres.UseVisualStyleBackColor = true;
            this.cbRequeteCircAutres.CheckedChanged += new System.EventHandler(this.cbRequeteCircAutres_CheckedChanged);
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 6);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(96, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "Problème Soulevé:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(429, 204);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(382, 204);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oui";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(17, 206);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(193, 13);
            this.label35.TabIndex = 11;
            this.label35.Text = "Le demandeur désire-t-il avoir un retour:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(10, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demandeur";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 98);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 13);
            this.label34.TabIndex = 10;
            this.label34.Text = "Courriel:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 20);
            this.textBox6.TabIndex = 9;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(292, 59);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(27, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "Fax:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(295, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 59);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(61, 13);
            this.label32.TabIndex = 5;
            this.label32.Text = "Téléphone:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(295, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(292, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 13);
            this.label31.TabIndex = 1;
            this.label31.Text = "Adresse:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Nom:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 7);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Numéro de demande:";
            // 
            // tabBD
            // 
            this.tabBD.Controls.Add(this.tcBD);
            this.tabBD.Location = new System.Drawing.Point(4, 54);
            this.tabBD.Name = "tabBD";
            this.tabBD.Padding = new System.Windows.Forms.Padding(3);
            this.tabBD.Size = new System.Drawing.Size(1443, 594);
            this.tabBD.TabIndex = 0;
            this.tabBD.Text = "Base de Données";
            this.tabBD.UseVisualStyleBackColor = true;
            // 
            // tcBD
            // 
            this.tcBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcBD.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcBD.Controls.Add(this.tabEmployes);
            this.tcBD.Controls.Add(this.tabPriorites);
            this.tcBD.Controls.Add(this.tabTaches);
            this.tcBD.Controls.Add(this.tabVeh);
            this.tcBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcBD.Location = new System.Drawing.Point(3, 0);
            this.tcBD.Name = "tcBD";
            this.tcBD.SelectedIndex = 0;
            this.tcBD.Size = new System.Drawing.Size(1434, 588);
            this.tcBD.TabIndex = 0;
            // 
            // tabEmployes
            // 
            this.tabEmployes.AutoScroll = true;
            this.tabEmployes.Controls.Add(this.groupBox3);
            this.tabEmployes.Controls.Add(this.groupBox4);
            this.tabEmployes.Controls.Add(this.groupBox5);
            this.tabEmployes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabEmployes.Location = new System.Drawing.Point(4, 25);
            this.tabEmployes.Name = "tabEmployes";
            this.tabEmployes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployes.Size = new System.Drawing.Size(1426, 559);
            this.tabEmployes.TabIndex = 0;
            this.tabEmployes.Text = "Employés";
            this.tabEmployes.UseVisualStyleBackColor = true;
            // 
            // tabPriorites
            // 
            this.tabPriorites.AutoScroll = true;
            this.tabPriorites.Controls.Add(this.bAjouterPriorite);
            this.tabPriorites.Controls.Add(this.bRechercherPriorite);
            this.tabPriorites.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPriorites.Location = new System.Drawing.Point(4, 25);
            this.tabPriorites.Name = "tabPriorites";
            this.tabPriorites.Padding = new System.Windows.Forms.Padding(3);
            this.tabPriorites.Size = new System.Drawing.Size(1426, 559);
            this.tabPriorites.TabIndex = 1;
            this.tabPriorites.Text = "Priorités Locales";
            this.tabPriorites.UseVisualStyleBackColor = true;
            // 
            // bAjouterPriorite
            // 
            this.bAjouterPriorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAjouterPriorite.Location = new System.Drawing.Point(209, 46);
            this.bAjouterPriorite.Name = "bAjouterPriorite";
            this.bAjouterPriorite.Size = new System.Drawing.Size(113, 34);
            this.bAjouterPriorite.TabIndex = 21;
            this.bAjouterPriorite.Text = "Ajouter";
            this.bAjouterPriorite.UseVisualStyleBackColor = true;
            this.bAjouterPriorite.Click += new System.EventHandler(this.bAjouterPriorite_Click);
            // 
            // bRechercherPriorite
            // 
            this.bRechercherPriorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRechercherPriorite.Location = new System.Drawing.Point(209, 6);
            this.bRechercherPriorite.Name = "bRechercherPriorite";
            this.bRechercherPriorite.Size = new System.Drawing.Size(113, 34);
            this.bRechercherPriorite.TabIndex = 20;
            this.bRechercherPriorite.Text = "Rechercher";
            this.bRechercherPriorite.UseVisualStyleBackColor = true;
            this.bRechercherPriorite.Click += new System.EventHandler(this.bRechercherPriorite_Click);
            // 
            // tabTaches
            // 
            this.tabTaches.AutoScroll = true;
            this.tabTaches.Controls.Add(this.bRechercherTachePatrouilleur);
            this.tabTaches.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabTaches.Location = new System.Drawing.Point(4, 25);
            this.tabTaches.Name = "tabTaches";
            this.tabTaches.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaches.Size = new System.Drawing.Size(1426, 559);
            this.tabTaches.TabIndex = 2;
            this.tabTaches.Text = "Tâches d\'un Patrouilleur";
            this.tabTaches.UseVisualStyleBackColor = true;
            // 
            // bRechercherTachePatrouilleur
            // 
            this.bRechercherTachePatrouilleur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRechercherTachePatrouilleur.Location = new System.Drawing.Point(196, 47);
            this.bRechercherTachePatrouilleur.Name = "bRechercherTachePatrouilleur";
            this.bRechercherTachePatrouilleur.Size = new System.Drawing.Size(113, 34);
            this.bRechercherTachePatrouilleur.TabIndex = 20;
            this.bRechercherTachePatrouilleur.Text = "Rechercher";
            this.bRechercherTachePatrouilleur.UseVisualStyleBackColor = true;
            this.bRechercherTachePatrouilleur.Click += new System.EventHandler(this.bRechercherTachePatrouilleur_Click);
            // 
            // tabVeh
            // 
            this.tabVeh.Controls.Add(this.gbEditVeh);
            this.tabVeh.Controls.Add(this.gbListeVeh);
            this.tabVeh.Controls.Add(this.gbRechercheVehicule);
            this.tabVeh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabVeh.Location = new System.Drawing.Point(4, 25);
            this.tabVeh.Name = "tabVeh";
            this.tabVeh.Size = new System.Drawing.Size(1426, 559);
            this.tabVeh.TabIndex = 3;
            this.tabVeh.Text = "Véhicules";
            this.tabVeh.UseVisualStyleBackColor = true;
            // 
            // gbEditVeh
            // 
            this.gbEditVeh.Controls.Add(this.tbNoVeh);
            this.gbEditVeh.Controls.Add(this.lNoVeh);
            this.gbEditVeh.Controls.Add(this.bDeleteVeh);
            this.gbEditVeh.Controls.Add(this.bCancelVeh);
            this.gbEditVeh.Controls.Add(this.bSaveVeh);
            this.gbEditVeh.Controls.Add(this.bModVeh);
            this.gbEditVeh.Controls.Add(this.bAddVeh);
            this.gbEditVeh.Location = new System.Drawing.Point(6, 62);
            this.gbEditVeh.Name = "gbEditVeh";
            this.gbEditVeh.Size = new System.Drawing.Size(406, 204);
            this.gbEditVeh.TabIndex = 40;
            this.gbEditVeh.TabStop = false;
            this.gbEditVeh.Text = "Éditer";
            // 
            // tbNoVeh
            // 
            this.tbNoVeh.Location = new System.Drawing.Point(118, 21);
            this.tbNoVeh.Name = "tbNoVeh";
            this.tbNoVeh.Size = new System.Drawing.Size(100, 20);
            this.tbNoVeh.TabIndex = 7;
            // 
            // lNoVeh
            // 
            this.lNoVeh.AutoSize = true;
            this.lNoVeh.Location = new System.Drawing.Point(6, 24);
            this.lNoVeh.Name = "lNoVeh";
            this.lNoVeh.Size = new System.Drawing.Size(106, 13);
            this.lNoVeh.TabIndex = 6;
            this.lNoVeh.Text = "Numéro du Véhicule:";
            // 
            // bDeleteVeh
            // 
            this.bDeleteVeh.Location = new System.Drawing.Point(325, 48);
            this.bDeleteVeh.Name = "bDeleteVeh";
            this.bDeleteVeh.Size = new System.Drawing.Size(75, 23);
            this.bDeleteVeh.TabIndex = 5;
            this.bDeleteVeh.Text = "Supprimer";
            this.bDeleteVeh.UseVisualStyleBackColor = true;
            this.bDeleteVeh.Click += new System.EventHandler(this.bDeleteVeh_Click);
            // 
            // bCancelVeh
            // 
            this.bCancelVeh.Location = new System.Drawing.Point(314, 175);
            this.bCancelVeh.Name = "bCancelVeh";
            this.bCancelVeh.Size = new System.Drawing.Size(86, 23);
            this.bCancelVeh.TabIndex = 4;
            this.bCancelVeh.Text = "Annuler";
            this.bCancelVeh.UseVisualStyleBackColor = true;
            this.bCancelVeh.Visible = false;
            this.bCancelVeh.Click += new System.EventHandler(this.bCancelVeh_Click);
            // 
            // bSaveVeh
            // 
            this.bSaveVeh.Location = new System.Drawing.Point(222, 175);
            this.bSaveVeh.Name = "bSaveVeh";
            this.bSaveVeh.Size = new System.Drawing.Size(86, 23);
            this.bSaveVeh.TabIndex = 3;
            this.bSaveVeh.Text = "Sauvegarder";
            this.bSaveVeh.UseVisualStyleBackColor = true;
            this.bSaveVeh.Visible = false;
            this.bSaveVeh.Click += new System.EventHandler(this.bSaveVeh_Click);
            // 
            // bModVeh
            // 
            this.bModVeh.Location = new System.Drawing.Point(325, 19);
            this.bModVeh.Name = "bModVeh";
            this.bModVeh.Size = new System.Drawing.Size(75, 23);
            this.bModVeh.TabIndex = 3;
            this.bModVeh.Text = "Modifier";
            this.bModVeh.UseVisualStyleBackColor = true;
            this.bModVeh.Click += new System.EventHandler(this.bModVeh_Click);
            // 
            // bAddVeh
            // 
            this.bAddVeh.Location = new System.Drawing.Point(325, 77);
            this.bAddVeh.Name = "bAddVeh";
            this.bAddVeh.Size = new System.Drawing.Size(75, 23);
            this.bAddVeh.TabIndex = 2;
            this.bAddVeh.Text = "Ajouter";
            this.bAddVeh.UseVisualStyleBackColor = true;
            this.bAddVeh.Click += new System.EventHandler(this.bAddVeh_Click);
            // 
            // gbListeVeh
            // 
            this.gbListeVeh.Controls.Add(this.dgvVeh);
            this.gbListeVeh.Location = new System.Drawing.Point(419, 8);
            this.gbListeVeh.Name = "gbListeVeh";
            this.gbListeVeh.Size = new System.Drawing.Size(157, 258);
            this.gbListeVeh.TabIndex = 39;
            this.gbListeVeh.TabStop = false;
            this.gbListeVeh.Text = "Liste";
            // 
            // dgvVeh
            // 
            this.dgvVeh.AllowUserToAddRows = false;
            this.dgvVeh.AllowUserToDeleteRows = false;
            this.dgvVeh.AutoGenerateColumns = false;
            this.dgvVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvVeh.DataSource = this.vehiculeBindingSource;
            this.dgvVeh.Location = new System.Drawing.Point(6, 15);
            this.dgvVeh.MultiSelect = false;
            this.dgvVeh.Name = "dgvVeh";
            this.dgvVeh.ReadOnly = true;
            this.dgvVeh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeh.Size = new System.Drawing.Size(145, 237);
            this.dgvVeh.TabIndex = 0;
            this.dgvVeh.SelectionChanged += new System.EventHandler(this.dgvVeh_SelectionChanged);
            // 
            // gbRechercheVehicule
            // 
            this.gbRechercheVehicule.Controls.Add(this.bAfficherToutVehicule);
            this.gbRechercheVehicule.Controls.Add(this.tbRechercherVehicule);
            this.gbRechercheVehicule.Controls.Add(this.bRechercherVehicule);
            this.gbRechercheVehicule.Location = new System.Drawing.Point(6, 8);
            this.gbRechercheVehicule.Name = "gbRechercheVehicule";
            this.gbRechercheVehicule.Size = new System.Drawing.Size(406, 47);
            this.gbRechercheVehicule.TabIndex = 38;
            this.gbRechercheVehicule.TabStop = false;
            this.gbRechercheVehicule.Text = "Rechercher par numéro de véhicule";
            // 
            // bAfficherToutVehicule
            // 
            this.bAfficherToutVehicule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAfficherToutVehicule.Location = new System.Drawing.Point(287, 15);
            this.bAfficherToutVehicule.Name = "bAfficherToutVehicule";
            this.bAfficherToutVehicule.Size = new System.Drawing.Size(113, 22);
            this.bAfficherToutVehicule.TabIndex = 32;
            this.bAfficherToutVehicule.Text = "Afficher Tout";
            this.bAfficherToutVehicule.UseVisualStyleBackColor = true;
            this.bAfficherToutVehicule.Click += new System.EventHandler(this.bAfficherToutVehicule_Click);
            // 
            // tbRechercherVehicule
            // 
            this.tbRechercherVehicule.Location = new System.Drawing.Point(9, 17);
            this.tbRechercherVehicule.Name = "tbRechercherVehicule";
            this.tbRechercherVehicule.Size = new System.Drawing.Size(100, 20);
            this.tbRechercherVehicule.TabIndex = 31;
            // 
            // bRechercherVehicule
            // 
            this.bRechercherVehicule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRechercherVehicule.Location = new System.Drawing.Point(168, 15);
            this.bRechercherVehicule.Name = "bRechercherVehicule";
            this.bRechercherVehicule.Size = new System.Drawing.Size(113, 22);
            this.bRechercherVehicule.TabIndex = 30;
            this.bRechercherVehicule.Text = "Rechercher";
            this.bRechercherVehicule.UseVisualStyleBackColor = true;
            this.bRechercherVehicule.Click += new System.EventHandler(this.bRechercherVehicule_Click);
            // 
            // tcMenu
            // 
            this.tcMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMenu.Controls.Add(this.tabBD);
            this.tcMenu.Controls.Add(this.tabFormulaire);
            this.tcMenu.Controls.Add(this.tabRapports);
            this.tcMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcMenu.ItemSize = new System.Drawing.Size(150, 50);
            this.tcMenu.Location = new System.Drawing.Point(12, 35);
            this.tcMenu.Multiline = true;
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.ShowToolTips = true;
            this.tcMenu.Size = new System.Drawing.Size(1451, 652);
            this.tcMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMenu.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.bSuppEmp);
            this.groupBox3.Controls.Add(this.bCancelEmp);
            this.groupBox3.Controls.Add(this.bSaveEmp);
            this.groupBox3.Controls.Add(this.bModEmp);
            this.groupBox3.Controls.Add(this.bAjoutEmp);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Location = new System.Drawing.Point(22, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 204);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Éditer";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(80, 27);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Visible = false;
            // 
            // bSuppEmp
            // 
            this.bSuppEmp.Location = new System.Drawing.Point(325, 53);
            this.bSuppEmp.Name = "bSuppEmp";
            this.bSuppEmp.Size = new System.Drawing.Size(75, 23);
            this.bSuppEmp.TabIndex = 5;
            this.bSuppEmp.Text = "Supprimer";
            this.bSuppEmp.UseVisualStyleBackColor = true;
            // 
            // bCancelEmp
            // 
            this.bCancelEmp.Location = new System.Drawing.Point(314, 175);
            this.bCancelEmp.Name = "bCancelEmp";
            this.bCancelEmp.Size = new System.Drawing.Size(86, 23);
            this.bCancelEmp.TabIndex = 4;
            this.bCancelEmp.Text = "Annuler";
            this.bCancelEmp.UseVisualStyleBackColor = true;
            this.bCancelEmp.Visible = false;
            // 
            // bSaveEmp
            // 
            this.bSaveEmp.Location = new System.Drawing.Point(222, 175);
            this.bSaveEmp.Name = "bSaveEmp";
            this.bSaveEmp.Size = new System.Drawing.Size(86, 23);
            this.bSaveEmp.TabIndex = 3;
            this.bSaveEmp.Text = "Sauvegarder";
            this.bSaveEmp.UseVisualStyleBackColor = true;
            this.bSaveEmp.Visible = false;
            // 
            // bModEmp
            // 
            this.bModEmp.Location = new System.Drawing.Point(325, 24);
            this.bModEmp.Name = "bModEmp";
            this.bModEmp.Size = new System.Drawing.Size(75, 23);
            this.bModEmp.TabIndex = 3;
            this.bModEmp.Text = "Modifier";
            this.bModEmp.UseVisualStyleBackColor = true;
            // 
            // bAjoutEmp
            // 
            this.bAjoutEmp.Location = new System.Drawing.Point(325, 80);
            this.bAjoutEmp.Name = "bAjoutEmp";
            this.bAjoutEmp.Size = new System.Drawing.Size(75, 23);
            this.bAjoutEmp.TabIndex = 2;
            this.bAjoutEmp.Text = "Ajouter";
            this.bAjoutEmp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 13);
            label2.TabIndex = 0;
            label2.Text = "No Vehicule:";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculeBindingSource, "NoVehicule", true));
            this.textBox8.Location = new System.Drawing.Point(80, 27);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PatrouilleurDataGridView);
            this.groupBox4.Controls.Add(this.rbEployeePat);
            this.groupBox4.Controls.Add(this.rbEmployeeTout);
            this.groupBox4.Controls.Add(this.employeeDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(494, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(832, 526);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liste";
            // 
            // PatrouilleurDataGridView
            // 
            this.PatrouilleurDataGridView.AllowUserToAddRows = false;
            this.PatrouilleurDataGridView.AllowUserToDeleteRows = false;
            this.PatrouilleurDataGridView.AutoGenerateColumns = false;
            this.PatrouilleurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatrouilleurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculeDataGridViewTextBoxColumn,
            this.Nom,
            this.Prenom,
            this.Equipe,
            this.Vehicule});
            this.PatrouilleurDataGridView.DataSource = this.patrouilleurBindingSource;
            this.PatrouilleurDataGridView.Location = new System.Drawing.Point(23, 324);
            this.PatrouilleurDataGridView.Name = "PatrouilleurDataGridView";
            this.PatrouilleurDataGridView.ReadOnly = true;
            this.PatrouilleurDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatrouilleurDataGridView.Size = new System.Drawing.Size(809, 181);
            this.PatrouilleurDataGridView.TabIndex = 44;
            // 
            // rbEployeePat
            // 
            this.rbEployeePat.AutoSize = true;
            this.rbEployeePat.Location = new System.Drawing.Point(191, 29);
            this.rbEployeePat.Name = "rbEployeePat";
            this.rbEployeePat.Size = new System.Drawing.Size(135, 17);
            this.rbEployeePat.TabIndex = 2;
            this.rbEployeePat.Text = "Patrouilleurs Seulement";
            this.rbEployeePat.UseVisualStyleBackColor = true;
            this.rbEployeePat.CheckedChanged += new System.EventHandler(this.rbEployeePat_CheckedChanged_1);
            // 
            // rbEmployeeTout
            // 
            this.rbEmployeeTout.AutoSize = true;
            this.rbEmployeeTout.Checked = true;
            this.rbEmployeeTout.Location = new System.Drawing.Point(53, 29);
            this.rbEmployeeTout.Name = "rbEmployeeTout";
            this.rbEmployeeTout.Size = new System.Drawing.Size(112, 17);
            this.rbEmployeeTout.TabIndex = 1;
            this.rbEmployeeTout.TabStop = true;
            this.rbEmployeeTout.Text = "Tous les employés";
            this.rbEmployeeTout.UseVisualStyleBackColor = true;
            this.rbEmployeeTout.CheckedChanged += new System.EventHandler(this.rbEmployeeTout_CheckedChanged_1);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(23, 52);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.Size = new System.Drawing.Size(809, 266);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblRechercheEmp);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.bAffEmp);
            this.groupBox5.Controls.Add(this.tbRechercheEmp);
            this.groupBox5.Controls.Add(this.bEmpRec);
            this.groupBox5.Location = new System.Drawing.Point(22, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 96);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rechercher par :";
            // 
            // bAffEmp
            // 
            this.bAffEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAffEmp.Location = new System.Drawing.Point(186, 19);
            this.bAffEmp.Name = "bAffEmp";
            this.bAffEmp.Size = new System.Drawing.Size(113, 22);
            this.bAffEmp.TabIndex = 32;
            this.bAffEmp.Text = "Afficher Tout";
            this.bAffEmp.UseVisualStyleBackColor = true;
            // 
            // tbRechercheEmp
            // 
            this.tbRechercheEmp.Location = new System.Drawing.Point(56, 52);
            this.tbRechercheEmp.Name = "tbRechercheEmp";
            this.tbRechercheEmp.Size = new System.Drawing.Size(124, 20);
            this.tbRechercheEmp.TabIndex = 31;
            // 
            // bEmpRec
            // 
            this.bEmpRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEmpRec.Location = new System.Drawing.Point(186, 50);
            this.bEmpRec.Name = "bEmpRec";
            this.bEmpRec.Size = new System.Drawing.Size(113, 22);
            this.bEmpRec.TabIndex = 30;
            this.bEmpRec.Text = "Rechercher";
            this.bEmpRec.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nom",
            "Prénom",
            "Numéro de Véhicule",
            "Matricule",
            "Équipe"});
            this.comboBox1.Location = new System.Drawing.Point(56, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // lblRechercheEmp
            // 
            this.lblRechercheEmp.AutoSize = true;
            this.lblRechercheEmp.Location = new System.Drawing.Point(6, 59);
            this.lblRechercheEmp.Name = "lblRechercheEmp";
            this.lblRechercheEmp.Size = new System.Drawing.Size(35, 13);
            this.lblRechercheEmp.TabIndex = 34;
            this.lblRechercheEmp.Text = "Nom :";
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataSource = typeof(GARMU.Modele.Vehicule);
            // 
            // patrouilleurBindingSource
            // 
            this.patrouilleurBindingSource.DataSource = typeof(GARMU.Modele.Patrouilleur);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(GARMU.Modele.Employee);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoVehicule";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoVehicule";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            this.matriculeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Equipe
            // 
            this.Equipe.DataPropertyName = "EquipeNoEquipe";
            this.Equipe.HeaderText = "Equipe";
            this.Equipe.Name = "Equipe";
            this.Equipe.ReadOnly = true;
            // 
            // Vehicule
            // 
            this.Vehicule.DataPropertyName = "VehiculeID";
            this.Vehicule.HeaderText = "Vehicule";
            this.Vehicule.Name = "Vehicule";
            this.Vehicule.ReadOnly = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1466, 692);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "GARMU";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabRapports.ResumeLayout(false);
            this.tcRapports.ResumeLayout(false);
            this.tabRequeteVigueur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.demandeSpecialeDataGridView)).EndInit();
            this.tabRequeteFerme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabSuiviRequete.ResumeLayout(false);
            this.tabSuiviRequete.PerformLayout();
            this.grpSuiviRetour.ResumeLayout(false);
            this.grpSuiviRetour.PerformLayout();
            this.gbSuiviSurveillance.ResumeLayout(false);
            this.gbSuiviSurveillance.PerformLayout();
            this.gbSuiviParl.ResumeLayout(false);
            this.gbSuiviParl.PerformLayout();
            this.tabFormulaire.ResumeLayout(false);
            this.tcFormulaires.ResumeLayout(false);
            this.tabPlanif.ResumeLayout(false);
            this.tabPlanif.PerformLayout();
            this.tlpPlanifMensuelle.ResumeLayout(false);
            this.tabPlanEquipe.ResumeLayout(false);
            this.tabPlanEquipe.PerformLayout();
            this.tlpPlanTravail.ResumeLayout(false);
            this.tabRapportQuot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapQuot)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.cboReqPlaintePriseNom.ResumeLayout(false);
            this.cboReqPlaintePriseNom.PerformLayout();
            this.tlpSuspectConnuRequete.ResumeLayout(false);
            this.tlpSuspectConnuRequete.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.bgDescriptionDemande.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabBD.ResumeLayout(false);
            this.tcBD.ResumeLayout(false);
            this.tabEmployes.ResumeLayout(false);
            this.tabPriorites.ResumeLayout(false);
            this.tabTaches.ResumeLayout(false);
            this.tabVeh.ResumeLayout(false);
            this.gbEditVeh.ResumeLayout(false);
            this.gbEditVeh.PerformLayout();
            this.gbListeVeh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).EndInit();
            this.gbRechercheVehicule.ResumeLayout(false);
            this.gbRechercheVehicule.PerformLayout();
            this.tcMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatrouilleurDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrouilleurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuAideItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private System.Windows.Forms.TabPage tabRapports;
        private System.Windows.Forms.TabControl tcRapports;
        private System.Windows.Forms.TabPage tabRequeteVigueur;
        private System.Windows.Forms.DataGridView demandeSpecialeDataGridView;
        private System.Windows.Forms.TabPage tabRequeteFerme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabSuiviRequete;
        private System.Windows.Forms.Button btnSuiviRecherche;
        private System.Windows.Forms.Button btnSuiviAjout;
        private System.Windows.Forms.GroupBox grpSuiviRetour;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.DateTimePicker dtpSuiviDateRetourDonneDemandeur;
        private System.Windows.Forms.ComboBox cbSuiviRetourPar;
        private System.Windows.Forms.TextBox tbSuiviRetourMin;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tbSuiviRetourMoyen;
        private System.Windows.Forms.TextBox tbSuiviRetourHrs;
        private System.Windows.Forms.CheckBox cbSuiviPARL;
        private System.Windows.Forms.CheckBox cbSuiviRetour;
        private System.Windows.Forms.GroupBox gbSuiviSurveillance;
        private System.Windows.Forms.RichTextBox rtbSuiviCommentaires;
        private System.Windows.Forms.RadioButton rbSuiviSurvNeg;
        private System.Windows.Forms.RadioButton rbSuiviSurvPos;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox tbSuiviDureeTotalSurveillance;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox tbSuiviNbConstatsEmis;
        private System.Windows.Forms.TextBox tbSuiviNbPoliciersParticipants;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.ComboBox cbSuiviPatrouilleurAssigne;
        private System.Windows.Forms.CheckBox cbSuiviVerifInfraLieux;
        private System.Windows.Forms.TextBox tbSuiviNoDemande;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.DateTimePicker dtpSuiviDateAgenda;
        private System.Windows.Forms.GroupBox gbSuiviParl;
        private System.Windows.Forms.ComboBox cbSuiviContolePar;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.ComboBox cbSuiviAlimentePar;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TabPage tabFormulaire;
        private System.Windows.Forms.TabControl tcFormulaires;
        private System.Windows.Forms.TabPage tabPlanif;
        private System.Windows.Forms.Button bEnregistrerPlanif;
        private System.Windows.Forms.Button bRechercherPlanif;
        private System.Windows.Forms.ComboBox cbAnneePlanif;
        private System.Windows.Forms.ComboBox cbMoisPlanif;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbThemePlanif;
        private System.Windows.Forms.Label lTheme;
        private System.Windows.Forms.TableLayoutPanel tlpPlanifMensuelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPlanEquipe;
        private System.Windows.Forms.Button btnEnregistrerPlan;
        private System.Windows.Forms.Button btnRechercherPlan;
        private System.Windows.Forms.ComboBox cboPlanifAnne;
        private System.Windows.Forms.ComboBox cboPlanifMois;
        private System.Windows.Forms.ComboBox cboPlanifEquipe;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TableLayoutPanel tlpPlanTravail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabRapportQuot;
        private System.Windows.Forms.Button bRapQuotVersRequ;
        private System.Windows.Forms.Button bRapQuotVersSuiviRequ;
        private System.Windows.Forms.Button bRapQuotVersActionsRequ;
        private System.Windows.Forms.DataGridView dgvRapQuot;
        private System.Windows.Forms.DataGridViewComboBoxColumn MatriculeRapQuot;
        private System.Windows.Forms.DataGridViewComboBoxColumn PatrouilleurRapQuot;
        private System.Windows.Forms.DataGridViewComboBoxColumn SecteurRapQuot;
        private System.Windows.Forms.DataGridViewComboBoxColumn VehiculeRapQuot;
        private System.Windows.Forms.DataGridViewComboBoxColumn AssignationRapQuot;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FaitRapQuot;
        private System.Windows.Forms.Button bRechercherRapQuot;
        private System.Windows.Forms.Button bEnregistrerRapQuot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbReleveRapQuot;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.DateTimePicker dtpRapQuot;
        private System.Windows.Forms.ComboBox cbEquipeRapQuot;
        private System.Windows.Forms.TabPage cboReqPlaintePriseNom;
        private System.Windows.Forms.DateTimePicker dtpDateRequete;
        private System.Windows.Forms.Button bRechercherNoRequete;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox tbDemandeRecuRequete;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbPlaintePriseParRequete;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.CheckBox cbSuspectConnuRequete;
        private System.Windows.Forms.TableLayoutPanel tlpSuspectConnuRequete;
        private System.Windows.Forms.TextBox tbDescPhysSuspect2Requete;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox tbNomSuspect1Requete;
        private System.Windows.Forms.TextBox tbPrenomSuspect1Requete;
        private System.Windows.Forms.TextBox tbDateNaissanceSuspect1Requete;
        private System.Windows.Forms.TextBox tbDescPhysSuspect1Requete;
        private System.Windows.Forms.TextBox tbNomSuspect2Requete;
        private System.Windows.Forms.TextBox tbPrenomSuspect2Requete;
        private System.Windows.Forms.TextBox tbDateNaissanceSuspect2Requete;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbContrevenantDemeureRequete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbDescriptionSuspectRequete;
        private System.Windows.Forms.TextBox tbMunicipaliteRequete;
        private System.Windows.Forms.TextBox tbLocalisationRequete;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lLocalisationRequete;
        private System.Windows.Forms.GroupBox bgDescriptionDemande;
        private System.Windows.Forms.RichTextBox rtbDescriptionDemande;
        private System.Windows.Forms.TextBox tbRequeteCircAutres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox cbRequeteCircAutres;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tabBD;
        private System.Windows.Forms.TabControl tcBD;
        private System.Windows.Forms.TabPage tabEmployes;
        private System.Windows.Forms.TabPage tabPriorites;
        private System.Windows.Forms.Button bAjouterPriorite;
        private System.Windows.Forms.Button bRechercherPriorite;
        private System.Windows.Forms.TabPage tabTaches;
        private System.Windows.Forms.Button bRechercherTachePatrouilleur;
        private System.Windows.Forms.TabPage tabVeh;
        private System.Windows.Forms.GroupBox gbEditVeh;
        private System.Windows.Forms.TextBox tbNoVeh;
        private System.Windows.Forms.Label lNoVeh;
        private System.Windows.Forms.Button bDeleteVeh;
        private System.Windows.Forms.Button bCancelVeh;
        private System.Windows.Forms.Button bSaveVeh;
        private System.Windows.Forms.Button bModVeh;
        private System.Windows.Forms.Button bAddVeh;
        private System.Windows.Forms.GroupBox gbListeVeh;
        private System.Windows.Forms.GroupBox gbRechercheVehicule;
        private System.Windows.Forms.Button bAfficherToutVehicule;
        private System.Windows.Forms.TextBox tbRechercherVehicule;
        private System.Windows.Forms.Button bRechercherVehicule;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.DataGridView dgvVeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button bSuppEmp;
        private System.Windows.Forms.Button bCancelEmp;
        private System.Windows.Forms.Button bSaveEmp;
        private System.Windows.Forms.Button bModEmp;
        private System.Windows.Forms.Button bAjoutEmp;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView PatrouilleurDataGridView;
        private System.Windows.Forms.RadioButton rbEployeePat;
        private System.Windows.Forms.RadioButton rbEmployeeTout;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bAffEmp;
        private System.Windows.Forms.TextBox tbRechercheEmp;
        private System.Windows.Forms.Button bEmpRec;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRechercheEmp;
        private System.Windows.Forms.BindingSource patrouilleurBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicule;
    }
}

