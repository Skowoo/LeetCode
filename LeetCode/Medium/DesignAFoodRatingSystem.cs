namespace LeetCode.Medium
{
    public class FoodRatings // 2353. DesignAFoodRatingSystem
    {
        private readonly Dictionary<string, SortedSet<Dish>> cuisineMap = [];
        private readonly Dictionary<string, Dish> dishMap = [];

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            for (var i = 0; i < foods.Length; i++)
            {
                var foodRating = new Dish(cuisines[i], foods[i], ratings[i]);

                dishMap.TryAdd(foodRating.Food, foodRating);

                if (cuisineMap.TryGetValue(foodRating.Cuisine, out SortedSet<Dish>? value))
                    value.Add(foodRating);
                else
                    cuisineMap.Add(foodRating.Cuisine, [foodRating]);
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            Dish? foodRating = dishMap[food];
            cuisineMap[foodRating.Cuisine].Remove(foodRating);
            foodRating.Rating = newRating;
            cuisineMap[foodRating.Cuisine].Add(foodRating);
        }

        public string HighestRated(string cuisine) => cuisineMap[cuisine].Max!.Food;

        private class Dish(string cuisine, string food, int rating) : IComparable<Dish>
        {
            public string Cuisine { get; set; } = cuisine;
            public string Food { get; set; } = food;
            public int Rating { get; set; } = rating;

            public int CompareTo(Dish? other)
            {
                if (other is null)
                    return 1;
                if (Rating > other.Rating)
                    return 1;
                if (Rating < other.Rating)
                    return -1;

                return string.Compare(other.Food, Food);
            }
        }
    }
}
