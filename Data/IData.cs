namespace VehiclesApp.Data
{
    public interface IData<T> where T : class
    {
        void WriteData(IEnumerable<T> data);
        IEnumerable<T> LoadData();
    }
}
