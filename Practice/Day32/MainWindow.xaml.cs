using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

using System.Windows;

namespace Day32
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<AnimalType> animalTypes = new ObservableCollection<AnimalType>();
        private ObservableCollection<Animal> animals;
        private ObservableCollection<Location> locations;
        private ObservableCollection<MovementPoint> movementPoints;

        private AnimalType selectedAnimalType;
        private Animal selectedAnimal;
        private Location selectedLocation;
        private MovementPoint selectedMovementPoint;

        private string connectionString = "Data Source=SNGLRTYCRVTUREO\\SQLEXPRESS;Initial Catalog=AnimalTracker;Integrated Security=True;trusted_connection=true;encrypt=false;";

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the data collections
            animalTypes = new ObservableCollection<AnimalType>();
            animals = new ObservableCollection<Animal>();
            locations = new ObservableCollection<Location>();
            movementPoints = new ObservableCollection<MovementPoint>();

            // Set the data sources for the DataGrids
            animalTypesDataGrid.ItemsSource = animalTypes;
            animalsDataGrid.ItemsSource = animals;
            locationsDataGrid.ItemsSource = locations;
            movementPointsDataGrid.ItemsSource = movementPoints;

            animalComboBox.ItemsSource = animals;
            animalComboBox.DisplayMemberPath = "AnimalName";

            // Load data from the database
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            animalTypes.Clear();
            animals.Clear();
            locations.Clear();
            movementPoints.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve animal types from the database
                    using (SqlCommand command = new SqlCommand("SELECT * FROM AnimalTypes", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int animalTypeID = reader.GetInt32(0);
                                string typeName = reader.GetString(1);
                                string typeDescription = reader.GetString(2);

                                animalTypes.Add(new AnimalType { AnimalTypeID = animalTypeID, TypeName = typeName, TypeDescription = typeDescription });
                            }
                        }
                    }

                    // Retrieve animals from the database
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Animals", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int animalID = reader.GetInt32(0);
                                int animalTypeID = reader.GetInt32(1);
                                string animalName = reader.GetString(2);
                                string animalDescription = reader.GetString(3);

                                animals.Add(new Animal { AnimalID = animalID, AnimalTypeID = animalTypeID, AnimalName = animalName, AnimalDescription = animalDescription });
                            }
                        }
                    }

                    // Retrieve locations from the database
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Locations", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int locationID = reader.GetInt32(0);
                                string locationName = reader.GetString(1);
                                string locationDescription = reader.GetString(2);
                                decimal latitude = reader.GetDecimal(3);
                                decimal longitude = reader.GetDecimal(4);

                                locations.Add(new Location { LocationID = locationID, LocationName = locationName, LocationDescription = locationDescription, Latitude = latitude, Longitude = longitude });
                            }
                        }
                    }

                    // Retrieve movement points from the database
                    using (SqlCommand command = new SqlCommand("SELECT * FROM MovementPoints", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int movementPointID = reader.GetInt32(0);
                                int animalID = reader.GetInt32(1);
                                int locationID = reader.GetInt32(2);
                                string dateTime = reader.GetString(3);

                                movementPoints.Add(new MovementPoint { MovementPointID = movementPointID, AnimalID = animalID, LocationID = locationID, DateTime = dateTime });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while retrieving data from the database: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AnimalTypesDataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {
            selectedAnimalType = animalTypesDataGrid.SelectedItem as AnimalType;
        }

        private void AnimalsDataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {
            selectedAnimal = animalsDataGrid.SelectedItem as Animal;
        }

        private void LocationsDataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {
            selectedLocation = locationsDataGrid.SelectedItem as Location;
        }

        private void MovementPointsDataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {
            selectedMovementPoint = movementPointsDataGrid.SelectedItem as MovementPoint;
        }

        private void AddAnimalType_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditAnimalType_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, выбран ли элемент в DataGrid
            if (animalTypesDataGrid.SelectedItem != null)
            {
                // Включаем редактирование ячеек в DataGrid
                animalTypesDataGrid.BeginEdit();

                // Получаем выбранный объект AnimalType
                AnimalType selectedAnimalType = animalTypesDataGrid.SelectedItem as AnimalType;

                // Обновляем данные в базе данных
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("UPDATE AnimalTypes SET TypeName = @TypeName, TypeDescription = @TypeDescription WHERE AnimalTypeID = @AnimalTypeID", connection))
                        {
                            if (selectedAnimalType != null)
                            {
                                command.Parameters.AddWithValue("@TypeName", selectedAnimalType.TypeName);
                                command.Parameters.AddWithValue("@TypeDescription", selectedAnimalType.TypeDescription);
                                command.Parameters.AddWithValue("@AnimalTypeID", selectedAnimalType.AnimalTypeID);
                            }

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while updating the animal type: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void DeleteAnimalType_Click(object sender, RoutedEventArgs e)
        {
            if (selectedAnimalType != null)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("DELETE FROM AnimalTypes WHERE AnimalTypeID = @AnimalTypeID", connection))
                        {
                            command.Parameters.AddWithValue("@AnimalTypeID", selectedAnimalType.AnimalTypeID);
                            command.ExecuteNonQuery();
                        }
                    }

                    animalTypes.Remove(selectedAnimalType);
                    selectedAnimalType = null;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the animal type: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditAnimal_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            if (selectedAnimal != null)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("DELETE FROM Animals WHERE AnimalID = @AnimalID", connection))
                        {
                            command.Parameters.AddWithValue("@AnimalID", selectedAnimal.AnimalID);
                            command.ExecuteNonQuery();
                        }
                    }

                    animals.Remove(selectedAnimal);
                    selectedAnimal = null;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the animal: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void AddLocation_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditLocation_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DeleteLocation_Click(object sender, RoutedEventArgs e)
        {
            if (selectedLocation != null)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("DELETE FROM Locations WHERE LocationID = @LocationID", connection))
                        {
                            command.Parameters.AddWithValue("@LocationID", selectedLocation.LocationID);
                            command.ExecuteNonQuery();
                        }
                    }

                    locations.Remove(selectedLocation);
                    selectedLocation = null;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the location: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void AddMovementPoint_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditMovementPoint_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DeleteMovementPoint_Click(object sender, RoutedEventArgs e)
        {
            if (selectedMovementPoint != null)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("DELETE FROM MovementPoints WHERE MovementPointID = @MovementPointID", connection))
                        {
                            command.Parameters.AddWithValue("@MovementPointID", selectedMovementPoint.MovementPointID);
                            command.ExecuteNonQuery();
                        }
                    }

                    movementPoints.Remove(selectedMovementPoint);
                    selectedMovementPoint = null;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the movement point: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SearchMovementPoints_Click(object sender, RoutedEventArgs e)
        {
            Animal selectedAnimal = animalComboBox.SelectedItem as Animal;

            if (selectedAnimal != null)
            {
                int selectedAnimalID = selectedAnimal.AnimalID;

                // Clear existing movement points
                movementPoints.Clear();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("SELECT * FROM MovementPoints WHERE AnimalID = @AnimalID", connection))
                        {
                            command.Parameters.AddWithValue("@AnimalID", selectedAnimalID);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int movementPointID = reader.GetInt32(0);
                                    int animalID = reader.GetInt32(1);
                                    int locationID = reader.GetInt32(2);
                                    string dateTime = reader.GetString(3);

                                    movementPoints.Add(new MovementPoint { MovementPointID = movementPointID, AnimalID = animalID, LocationID = locationID, DateTime = dateTime });
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while retrieving movement points: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                // Refresh the DataGrid to display the new movement points
                movementPointsDataGrid.Items.Refresh();
            }
        }
    }

    public class AnimalType
    {
        public int AnimalTypeID { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
    }

    public class Animal
    {
        public int AnimalID { get; set; }
        public int AnimalTypeID { get; set; }
        public string AnimalName { get; set; }
        public string AnimalDescription { get; set; }
    }

    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class MovementPoint
    {
        public int MovementPointID { get; set; }
        public int AnimalID { get; set; }
        public int LocationID { get; set; }
        public string DateTime { get; set; }
    }
}
