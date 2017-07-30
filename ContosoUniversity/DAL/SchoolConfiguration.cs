using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration : DbConfiguration
    {
        /// <summary>
        /// 当您访问云服务时，连接问题很多或大部分是短暂的，也就是说，他们在短时间内解决问题。
        /// 因此，当您尝试数据库操作并获得通常是短暂的错误类型时，您可以在短暂的等待后再次尝试该操作，
        /// 并且操作可能会成功。如果您通过自动尝试再次处理短暂的错误，您的用户可以为您的用户提供更好的体验，
        /// 使其中的大多数对客户不可见。Entity Framework 6中的连接弹性功能自动执行重试失败的SQL查询的过程。
        /// </summary>
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}