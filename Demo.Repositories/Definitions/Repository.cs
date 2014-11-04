using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Repositories.Definitions
{
	public class Repository<TEntity> : Framework.Repositories.Definitions.Repository<DemoEntities, TEntity>
		where TEntity : class, new()
	{
	}
}
