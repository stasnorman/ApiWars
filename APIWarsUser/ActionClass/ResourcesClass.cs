namespace APIWarsUser.ActionClass
{
    public class ResourcesClass : IResources
    {
        readonly SpaceGameWorldContext _context;

        public ResourcesClass(SpaceGameWorldContext context) => _context = context;

        public IQueryable<AccountResources> GetResources(string resourcesKey)
        {
            try
            {
                var data = _context.Accounts.Select(
                    x => new AccountResources()
                    {
                        ApiKey = x.ApiKey,
                        Login = x.Login,
                        Name = x .Name,
                        Email = x .Email,
                        MaxRl = x .MaxRl,
                        //RoleNameNavigation = x .RoleNameNavigation,
                        //DeveloperInTeams = x .DeveloperInTeams, 
                        //InformationDrones = x .InformationDrones,
                        //ObjectAvailables = x .ObjectAvailables,
                    }).Where(a => a.ApiKey == resourcesKey).AsEnumerable();

                var sel = data.ToList();

                return (IQueryable<AccountResources>)data;
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }
    }
}
