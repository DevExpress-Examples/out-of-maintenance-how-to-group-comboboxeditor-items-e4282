// Developer Express Code Central Example:
// How to group ComboBoxEditor items
// 
// This example demonstrates how to group ComboBoxEditor items. DxEditors support
// binding to ICollectionView, so the main idea of this feature realization is the
// use of ListCollectionView. The basic logic is implemented in
// ComboBoxEditGroupingBehavior, which is attached to the editor.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4282

using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace WpfApplication1 {
    public static class DataHelper {
        public static IList<City> GetData() {

            ObservableCollection<City> cities = new ObservableCollection<City>();
            cities.Add(new City(1, "London", "UK"));
            cities.Add(new City(1, "Glasgow", "UK"));
            cities.Add(new City(1, "Edinburgh", "UK"));
            cities.Add(new City(1, "Aberdeen Dundee", "UK"));

            cities.Add(new City(2, "Washington", "USA"));
            cities.Add(new City(2, "Chicago", "USA"));
            cities.Add(new City(2, "Los Angeles", "USA"));
            cities.Add(new City(2, "New York", "USA"));

            cities.Add(new City(3, "Hong Kong", "China"));
            cities.Add(new City(3, "Shanghai", "China"));
            cities.Add(new City(3, "Beijing", "China"));
            cities.Add(new City(3, "Tianjin", "China"));

            return cities;
        }
    }

    public class City {
        public City() {
        }

        public City(int id, string cityName, string country) {
            ID = id;
            CityName = cityName;
            Country = country;
        }

        public int ID { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
    }
}
