import { HttpHelper } from "../Helpers/HttpHelper.js";
import { Album } from "../Models/Album.js";

export class AlbumRepository extends HttpHelper {

    constructor() {
        super();
        let self = this;
        self.baseUrl += "api/album"
    }

    async getAlbums(): Promise<Array<Album>> {
        let self = this;

        const response = await self.http <Array<Album>>(self.baseUrl);
        return response.parsedBody;
    }
}