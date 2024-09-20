namespace MultitonPattern.Models
{
    // This class is the "Manager" of the Multiton, responsible for handling controlled instances
    public class MultitonManager
    {
        // Dictionary that stores instances according to their unique key
        private static Dictionary<string, MultitonManager> _instances = new Dictionary<string, MultitonManager>();

        // Private constructor to prevent direct instance creation outside this class
        private MultitonManager()
        { }

        // Public and static method to get or create a Multiton instance based on the provided key
        public static MultitonManager GetInstance(string key)
        {
            // If the key doesn't exist in the dictionary, create a new instance and store it
            if (!_instances.ContainsKey(key))
            {
                _instances[key] = new MultitonManager();
            }
            // Return the instance corresponding to the key
            return _instances[key];
        }
    }
}