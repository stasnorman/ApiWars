namespace APIWarsUser.ActionClass
{
    /// <summary>
    /// Класс обработки данных способности класса дрона
    /// </summary>
    public class EfficiencyActionClass : IEfficiencyAction
    {
        private readonly SpaceGameWorldContext _context;
        public EfficiencyActionClass(SpaceGameWorldContext context) => _context = context;

        /// <summary>
        /// Получение массива по названию способности класса дрона
        /// </summary>
        /// <returns>Возвращает данные: массив с данными дрона
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<EfficiencyActionDTO> GetEfficiencyAction(string name)
        {
            try
            {

                var data = _context.EfficiencyActions.AsQueryable().Select(
                        effAct => new EfficiencyActionDTO()
                        {
                            Name = effAct.Name,
                            Description = effAct.Description,
                            ValueAction = effAct.ValueAction,
                        }).Where(ea => ea.Name == name);
                return data.ToList();
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }

        /// <summary>
        /// Получение массива по способности каждого класса дрона
        /// </summary>
        /// <returns>Возвращает данные: массив с данными всех классов дронов
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<EfficiencyActionDTO> GetEfficiencyActions()
        {
            try
            {
                var data = _context.EfficiencyActions.Select(
                    effAct => new EfficiencyActionDTO()
                    {
                        Name = effAct.Name,
                        Description = effAct.Description,
                        ValueAction = effAct.ValueAction,
                    }
                    ).ToList();
                return data;
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }
    }
}
