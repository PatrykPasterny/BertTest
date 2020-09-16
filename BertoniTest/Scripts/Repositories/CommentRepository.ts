import { HttpHelper } from "../Helpers/HttpHelper.js";
import { Comment } from "../Models/Comment.js";

export class CommentRepository extends HttpHelper {

    constructor() {
        super();
        let self = this;
        self.baseUrl += "api/photo"
    }

    async getAllPhotos(): Promise<Comment[]> {
        let self = this;

        const response = await self.http<Comment[]>(self.baseUrl + "/Get");
        return response.parsedBody;
    }

    async getAllPhotosForAlbum(photoId: number): Promise<Comment[]> {
        let self = this;

        const response = await self.http<Comment[]>(self.baseUrl + "/GetAllCommentsForPhoto?photoId=" + photoId);
        return response.parsedBody;
    }
}