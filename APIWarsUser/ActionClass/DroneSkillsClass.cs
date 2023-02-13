namespace APIWarsUser.ActionClass
{
    public class DroneSkillsClass : IDroneSkills
    {
        private readonly SpaceGameWorldContext _context;
        public DroneSkillsClass(SpaceGameWorldContext context) => _context = context;

        public List<DroneSkillsSet> GetSkills()
        {
            try
            {
                var data = _context.DroneSkillsSets;
                return data.ToList();
            }
            catch (Exception)
            {
                Results.BadRequest();
                throw;
            }
        }

        public List<DroneSkillsSet> GetSkill(string shortName)
        {
            try
            {
                var data = _context.DroneSkillsSets.Where(d => d.ShortNameDrone == shortName);
                return data.ToList();
            }
            catch (Exception)
            {
                Results.BadRequest();
                throw;
            }
        }
    }
}
