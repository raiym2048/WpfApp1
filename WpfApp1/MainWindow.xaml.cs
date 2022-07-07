using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void n3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void upbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void upbtn_Click_1(object sender, RoutedEventArgs e)

        {

            string Login = login.Text.Trim();
            string Email = email.Text.Trim();
            string Pass = password.Password.Trim();

            User u = new User(1, Login,Email,Pass);
            AppContxtOrRepository appContxtOrRepository = new AppContxtOrRepository();  
            appContxtOrRepository.Users.Add(u);




            Auth form1 = new Auth();
            form1.Show();
            Hide();

        }
    }
}

/*<Grid.ColumnDefinitions> ++
            <ColumnDefinition></ColumnDefinition>
            <ColumnDefinition></ColumnDefinition>
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition></RowDefinition>
            <RowDefinition></RowDefinition>
        </Grid.RowDefinitions>
        <Button Grid.Column="0" Grid.Row="0" Background="Yellow" Content="aehfn" Click="Button_Click" x:Name="btn1"></Button>


        <Button Grid.Column="1" Grid.Row="1" Background="Red" Content="fjslfse" x:Name="btn2" Click="Button_Click_1" ></Button>
        <TextBlock Grid.Column="0" Grid.Row="1" Background="Green" Text="new txt" x:Name="txtpan1" FontSize="24px"></TextBlock>
        <TextBox Grid.Column="1" HorizontalAlignment="Left" Margin="65,109,0,0" TextWrapping="Wrap" Text="TextBox" VerticalAlignment="Top" Width="222" Height="46" x:Name="txt1"/>*/
/*
 <DockPanel LastChildFill="True">
            <Button Background="Gray" DockPanel.Dock="Right" Content="ahdkn"></Button>
            <Button Background="Green" DockPanel.Dock="Left" Content="hifKN"></Button>
            <Button Background="Red" DockPanel.Dock="Bottom" Content="Ajdlkn"></Button>
            <Button Background="Red" DockPanel.Dock="Top" Content="Lhdj"></Button>
            <Button Background="AliceBlue" Content="hakfN" DockPanel.Dock="Left"></Button>
            <Button Background="Aqua" Content="aohkndf"></Button>
        </DockPanel>*/
