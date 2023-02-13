namespace APIWarsUser.Interface
{
    public interface IDroneSkills
    {
        public List<DroneSkillsSet> GetSkills();
        public List<DroneSkillsSet> GetSkill(string shortName);
    }
}
