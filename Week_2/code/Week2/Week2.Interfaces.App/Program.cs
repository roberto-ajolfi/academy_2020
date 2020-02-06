using System;

namespace Week2.Interfaces.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperDataRepository repository = new SuperDataRepository();

            DataAccessService service = 
                new DataAccessService(repository);

            Console.WriteLine("Interface");

            var data = service.Data();

            foreach(var item in data)
            {
                Console.WriteLine("=> {0}", item);
            }

        }
    }

    class DataAccessService
    {
        private IDataRepository _repository;
        public DataAccessService(IDataRepository repo)
        {
            _repository = repo;
        }

        public string[] Data()
        {
            return _repository.GetData();
        }
    }

    interface IDataRepository
    {
        string[] GetData();
    }

    class DataRepository : IDataRepository
    {
        public DataRepository()
        {

        }

        public bool IsActive() { return true; }

        public string[] GetData()
        {
            return new string[]
            {
                "Prima",
                "Seconda",
                "Terza"
            };
        }
    }

    class SuperDataRepository : IDataRepository
    {
        public SuperDataRepository()
        {

        }

        public string[] GetData()
        {
            return new string[]
            {
                "Prima",
                "Seconda",
                "Terza",
                "SUPER FAST!!!"
            };
        }
    }
}
