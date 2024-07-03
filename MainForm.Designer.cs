namespace LaPosadaClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.ColNombre = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.ColPrecio = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.alertBox = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.pageProductos = new DevExpress.XtraTab.XtraTabPage();
            this.btnCart2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.gridProductos = new DevExpress.XtraGrid.GridControl();
            this.viewProductos = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageCategorias = new DevExpress.XtraTab.XtraTabPage();
            this.btnCart1 = new DevExpress.XtraEditors.SimpleButton();
            this.settingsBtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridCategorias = new DevExpress.XtraGrid.GridControl();
            this.viewCategorias = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.Imagen = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PageControl = new DevExpress.XtraTab.XtraTabControl();
            this.pageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pageCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageControl)).BeginInit();
            this.PageControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColNombre
            // 
            this.ColNombre.Caption = "Nombre";
            this.ColNombre.FieldName = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.OptionsColumn.AllowEdit = false;
            this.ColNombre.Visible = true;
            this.ColNombre.VisibleIndex = 0;
            // 
            // ColPrecio
            // 
            this.ColPrecio.Caption = "Precio";
            this.ColPrecio.FieldName = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Visible = true;
            this.ColPrecio.VisibleIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 0;
            // 
            // alertBox
            // 
            this.alertBox.AllowHotTrack = false;
            this.alertBox.AutoFormDelay = 2000;
            this.alertBox.AutoHeight = true;
            this.alertBox.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.alertBox.FormMaxCount = 1;
            this.alertBox.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alertBox.HideAnimationType = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alertBox.ShowAnimationType = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alertBox.ShowCloseButton = false;
            this.alertBox.ShowPinButton = false;
            this.alertBox.ShowToolTips = false;
            this.alertBox.MouseFormEnter += new DevExpress.XtraBars.Alerter.AlertEventHandler(this.alertBox_MouseFormEnter);
            // 
            // pageProductos
            // 
            this.pageProductos.Controls.Add(this.btnCart2);
            this.pageProductos.Controls.Add(this.btnBack);
            this.pageProductos.Controls.Add(this.gridProductos);
            this.pageProductos.Name = "pageProductos";
            this.pageProductos.Size = new System.Drawing.Size(798, 419);
            this.pageProductos.Text = "Productos";
            // 
            // btnCart2
            // 
            this.btnCart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart2.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnCart2.Appearance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart2.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCart2.Appearance.Options.UseBackColor = true;
            this.btnCart2.Appearance.Options.UseFont = true;
            this.btnCart2.Appearance.Options.UseForeColor = true;
            this.btnCart2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnCart2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCart2.ImageOptions.Image")));
            this.btnCart2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightBottom;
            this.btnCart2.Location = new System.Drawing.Point(723, 3);
            this.btnCart2.Name = "btnCart2";
            this.btnCart2.Size = new System.Drawing.Size(72, 70);
            this.btnCart2.TabIndex = 6;
            this.btnCart2.Text = "0";
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.AutoSize = true;
            this.btnBack.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnBack.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBack.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBack.ImageOptions.SvgImage")));
            this.btnBack.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 2;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.BackgroundImage = global::LaPosadaClient.Properties.Resources.woodBG;
            this.gridProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductos.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gridProductos.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridProductos.Location = new System.Drawing.Point(0, 0);
            this.gridProductos.MainView = this.viewProductos;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(798, 419);
            this.gridProductos.TabIndex = 3;
            this.gridProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewProductos,
            this.gridView1});
            // 
            // viewProductos
            // 
            this.viewProductos.Appearance.EmptySpace.BackColor = System.Drawing.Color.Transparent;
            this.viewProductos.Appearance.EmptySpace.Options.UseBackColor = true;
            this.viewProductos.Appearance.Group.BackColor = System.Drawing.Color.Transparent;
            this.viewProductos.Appearance.Group.Options.UseBackColor = true;
            this.viewProductos.Appearance.ItemNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.viewProductos.Appearance.ItemNormal.Options.UseBackColor = true;
            this.viewProductos.Appearance.ItemPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.viewProductos.Appearance.ItemPressed.Options.UseBackColor = true;
            this.viewProductos.Appearance.ItemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(9)))), ((int)(((byte)(4)))));
            this.viewProductos.Appearance.ItemSelected.Options.UseBackColor = true;
            this.viewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColNombre,
            this.ColPrecio});
            this.viewProductos.GridControl = this.gridProductos;
            this.viewProductos.Name = "viewProductos";
            this.viewProductos.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewProductos.OptionsTiles.IndentBetweenGroups = 0;
            this.viewProductos.OptionsTiles.IndentBetweenItems = 17;
            this.viewProductos.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(5);
            this.viewProductos.OptionsTiles.ItemSize = new System.Drawing.Size(250, 300);
            this.viewProductos.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.viewProductos.OptionsTiles.Padding = new System.Windows.Forms.Padding(5);
            this.viewProductos.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.viewProductos.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 151D;
            tableRowDefinition2.Length.Value = 95D;
            tableRowDefinition3.Length.Value = 44D;
            this.viewProductos.TileRows.Add(tableRowDefinition1);
            this.viewProductos.TileRows.Add(tableRowDefinition2);
            this.viewProductos.TileRows.Add(tableRowDefinition3);
            tileViewItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement1.ImageOptions.ImageSize = new System.Drawing.Size(150, 150);
            tileViewItemElement1.Text = "categoryImage";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.TextVisible = false;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.ColNombre;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "ColNombre";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Column = this.ColPrecio;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "ColPrecio";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.viewProductos.TileTemplate.Add(tileViewItemElement1);
            this.viewProductos.TileTemplate.Add(tileViewItemElement2);
            this.viewProductos.TileTemplate.Add(tileViewItemElement3);
            this.viewProductos.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.viewProductos_ItemClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridProductos;
            this.gridView1.Name = "gridView1";
            // 
            // pageCategorias
            // 
            this.pageCategorias.Appearance.Header.BackColor = System.Drawing.Color.Transparent;
            this.pageCategorias.Appearance.Header.Options.UseBackColor = true;
            this.pageCategorias.Appearance.HeaderActive.BackColor = System.Drawing.Color.Transparent;
            this.pageCategorias.Appearance.HeaderActive.Options.UseBackColor = true;
            this.pageCategorias.Appearance.HeaderDisabled.BackColor = System.Drawing.Color.Transparent;
            this.pageCategorias.Appearance.HeaderDisabled.Options.UseBackColor = true;
            this.pageCategorias.Appearance.HeaderHotTracked.BackColor = System.Drawing.Color.Transparent;
            this.pageCategorias.Appearance.HeaderHotTracked.Options.UseBackColor = true;
            this.pageCategorias.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.pageCategorias.Appearance.PageClient.Options.UseBackColor = true;
            this.pageCategorias.Controls.Add(this.btnCart1);
            this.pageCategorias.Controls.Add(this.settingsBtn);
            this.pageCategorias.Controls.Add(this.gridCategorias);
            this.pageCategorias.Name = "pageCategorias";
            this.pageCategorias.Size = new System.Drawing.Size(798, 419);
            this.pageCategorias.Text = "Categorias";
            // 
            // btnCart1
            // 
            this.btnCart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart1.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnCart1.Appearance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart1.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCart1.Appearance.Options.UseBackColor = true;
            this.btnCart1.Appearance.Options.UseFont = true;
            this.btnCart1.Appearance.Options.UseForeColor = true;
            this.btnCart1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnCart1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCart1.ImageOptions.Image")));
            this.btnCart1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightBottom;
            this.btnCart1.Location = new System.Drawing.Point(723, 3);
            this.btnCart1.Name = "btnCart1";
            this.btnCart1.Size = new System.Drawing.Size(72, 70);
            this.btnCart1.TabIndex = 5;
            this.btnCart1.Text = "0";
            this.btnCart1.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.settingsBtn.Appearance.Options.UseBackColor = true;
            this.settingsBtn.AutoSize = true;
            this.settingsBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.ImageOptions.Image")));
            this.settingsBtn.Location = new System.Drawing.Point(3, 378);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(40, 38);
            this.settingsBtn.TabIndex = 0;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // gridCategorias
            // 
            this.gridCategorias.BackgroundImage = global::LaPosadaClient.Properties.Resources.woodBG;
            this.gridCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategorias.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gridCategorias.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridCategorias.Location = new System.Drawing.Point(0, 0);
            this.gridCategorias.MainView = this.viewCategorias;
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.Size = new System.Drawing.Size(798, 419);
            this.gridCategorias.TabIndex = 0;
            this.gridCategorias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCategorias,
            this.gridView2});
            // 
            // viewCategorias
            // 
            this.viewCategorias.Appearance.EmptySpace.BackColor = System.Drawing.Color.Transparent;
            this.viewCategorias.Appearance.EmptySpace.Options.UseBackColor = true;
            this.viewCategorias.Appearance.Group.BackColor = System.Drawing.Color.Transparent;
            this.viewCategorias.Appearance.Group.Options.UseBackColor = true;
            this.viewCategorias.Appearance.ItemNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.viewCategorias.Appearance.ItemNormal.Options.UseBackColor = true;
            this.viewCategorias.Appearance.ItemPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.viewCategorias.Appearance.ItemPressed.Options.UseBackColor = true;
            this.viewCategorias.Appearance.ItemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(9)))), ((int)(((byte)(4)))));
            this.viewCategorias.Appearance.ItemSelected.Options.UseBackColor = true;
            this.viewCategorias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nombre,
            this.Imagen});
            this.viewCategorias.GridControl = this.gridCategorias;
            this.viewCategorias.Name = "viewCategorias";
            this.viewCategorias.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewCategorias.OptionsTiles.IndentBetweenGroups = 0;
            this.viewCategorias.OptionsTiles.IndentBetweenItems = 17;
            this.viewCategorias.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(5);
            this.viewCategorias.OptionsTiles.ItemSize = new System.Drawing.Size(250, 300);
            this.viewCategorias.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.viewCategorias.OptionsTiles.Padding = new System.Windows.Forms.Padding(5);
            this.viewCategorias.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.viewCategorias.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition4.Length.Value = 210D;
            tableRowDefinition5.Length.Value = 80D;
            this.viewCategorias.TileRows.Add(tableRowDefinition4);
            this.viewCategorias.TileRows.Add(tableRowDefinition5);
            tileViewItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement4.ImageOptions.ImageSize = new System.Drawing.Size(150, 150);
            tileViewItemElement4.Text = "categoryImage";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.TextVisible = false;
            tileViewItemElement5.Appearance.Hovered.Options.UseTextOptions = true;
            tileViewItemElement5.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            tileViewItemElement5.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileViewItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement5.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileViewItemElement5.Column = this.Nombre;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.RowIndex = 1;
            tileViewItemElement5.Text = "Nombre";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.viewCategorias.TileTemplate.Add(tileViewItemElement4);
            this.viewCategorias.TileTemplate.Add(tileViewItemElement5);
            this.viewCategorias.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.viewCategorias_ItemClick);
            // 
            // Imagen
            // 
            this.Imagen.Caption = "Imagen";
            this.Imagen.FieldName = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.Visible = true;
            this.Imagen.VisibleIndex = 1;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridCategorias;
            this.gridView2.Name = "gridView2";
            // 
            // PageControl
            // 
            this.PageControl.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.PageControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PageControl.Appearance.Options.UseBackColor = true;
            this.PageControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageControl.Location = new System.Drawing.Point(0, 0);
            this.PageControl.Name = "PageControl";
            this.PageControl.SelectedTabPage = this.pageCategorias;
            this.PageControl.Size = new System.Drawing.Size(800, 450);
            this.PageControl.TabIndex = 1;
            this.PageControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageCategorias,
            this.pageProductos});
            this.PageControl.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.True;
            this.PageControl.Transition.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            this.PageControl.Transition.TransitionType = pushTransition1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PageControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "FormCategorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pageProductos.ResumeLayout(false);
            this.pageProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pageCategorias.ResumeLayout(false);
            this.pageCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageControl)).EndInit();
            this.PageControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Alerter.AlertControl alertBox;
        private DevExpress.XtraTab.XtraTabPage pageProductos;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraGrid.GridControl gridProductos;
        private DevExpress.XtraGrid.Views.Tile.TileView viewProductos;
        private DevExpress.XtraGrid.Columns.TileViewColumn ColNombre;
        private DevExpress.XtraGrid.Columns.TileViewColumn ColPrecio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage pageCategorias;
        private DevExpress.XtraEditors.SimpleButton settingsBtn;
        private DevExpress.XtraGrid.GridControl gridCategorias;
        private DevExpress.XtraGrid.Views.Tile.TileView viewCategorias;
        private DevExpress.XtraGrid.Columns.TileViewColumn Nombre;
        private DevExpress.XtraGrid.Columns.TileViewColumn Imagen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabControl PageControl;
        private DevExpress.XtraEditors.SimpleButton btnCart1;
        private DevExpress.XtraEditors.SimpleButton btnCart2;
    }
}