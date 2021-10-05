import React from 'react'
import { AiOutlineStar } from "react-icons/ai"
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { CardActionArea } from '@mui/material';
import { IconContext } from "react-icons";

export const Media = ({ media, clickStar }) => {
    return (
        <Card sx={{ width: 300, height: 350, margin: 5 }}>
            <CardActionArea>
                <CardMedia
                    component="img"
                    height="140"
                    image={media.coverImage}
                    alt="green iguana"
                />
                <CardContent>
                    <Typography gutterBottom variant="h5" component="div">
                        {media.title}
                    </Typography>
                    <Typography gutterBottom variant="h8" component="div">
                        {media.releaseDate}
                    </Typography>
                    <Typography variant="body1" color="text.secondary">
                        Average rating: {media.averageRating}
                    </Typography>
                    <Typography variant="body2" color="text.secondary">
                        {media.description}
                    </Typography>
                    <IconContext.Provider value={{ color: "yellow"}}>
                        <div onClick={() => clickStar(media.id)}>
                            <AiOutlineStar size={32} />
                        </div>
                    </IconContext.Provider>
                </CardContent>
            </CardActionArea>
        </Card>
    )
}
