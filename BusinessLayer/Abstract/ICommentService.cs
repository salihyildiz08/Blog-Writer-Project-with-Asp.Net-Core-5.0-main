using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void CommentAdd(Comment comment);
		//void CategoryDelete(Comment comment);
		//void CategoryUpdate(Comment comment);
		List<Comment> GetCommentList(int id);
        //Category GetCategoryById(int id);
        List<Comment> GetCommentWithBlog();
    }
}
