namespace Jellyfin.HardwareVisualizer.Client.Service.Http.Base;

public abstract class RestHttpAccessBase<TEntity> : HttpAccessBase
{
	protected RestHttpAccessBase(HttpService httpService, string url) : base(httpService, url)
	{
	}

	public virtual ValueTask<ApiResult<TEntity>> GetSingle(int id)
	{
		return Get<TEntity>(BuildApi("GetSingle", new
		{
			id
		}));
	}

	public virtual ValueTask<ApiResult<TEntity[]>> GetList(int[] ids)
	{
		return Get<TEntity[]>(BuildApi("GetMany", new
		{
			ids
		}));
	}

	public virtual ValueTask<ApiResult<TEntity[]>> GetList()
	{
		return Get<TEntity[]>(BuildApi("GetList"));
	}
}

public class RestHttpAccessBase<TEntity, TPostEntity> : RestHttpAccessBase<TEntity>
{
	public RestHttpAccessBase(HttpService httpService, string url) : base(httpService, url)
	{
	}


	public virtual ValueTask<ApiResult<TEntity>> Update(TPostEntity entity, int id)
	{
		return Post<TPostEntity, TEntity>(BuildApi("Update", new
		{
			id
		}), entity);
	}

	public virtual ValueTask<ApiResult<TEntity>> Create(TPostEntity entity)
	{
		return Post<TPostEntity, TEntity>(BuildApi("Create"), entity);
	}

	public virtual ValueTask<ApiResult> Delete(int id)
	{
		return Post(BuildApi("Delete", new { id }));
	}
}