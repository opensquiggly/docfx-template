using System.Threading.Tasks;

namespace Docfx2xml.Converter
{
  public interface IDataConverter
  {
    public void Convert();

    public Task ConvertAsync();
  }
}
