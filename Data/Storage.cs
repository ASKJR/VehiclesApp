namespace VehiclesApp.Data
{
    public class Storage<T> : IData<T> where T : class
    {
        public IEnumerable<T> LoadData()
        {
            throw new NotImplementedException();
        }

        public void WriteData(IEnumerable<T> data)
        {
            using StreamWriter writetext = new($"{typeof(T).Name}.txt");
            writetext.WriteLine(string.Join('\n', data.Select(x => x.ToString())));
        }
    }
}
