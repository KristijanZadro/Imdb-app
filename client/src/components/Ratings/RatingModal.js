import { useState } from 'react'
import { Modal } from '../../containers/Modal'
import { Rating } from 'react-simple-star-rating'
import { useDispatch } from 'react-redux'
import { postRating } from '../../redux/actions/ratings/ratings'
import { Button } from '../../containers/Button/Button'

export const RatingModal = ({ handleShowRatingModal, showRatingModal, mediaId, mediaType }) => {
    const [rating, setRating] = useState(0)
    const dispatch = useDispatch()

    const handleRating = (rate) => {
        setRating(rate)
    }

    const handlePostRating = () => {
        dispatch(postRating(rating, mediaId, mediaType))
        handleShowRatingModal()
    }
    return (
        <div>
            <Modal
                handleShowModal={handleShowRatingModal}
                open={showRatingModal}
                modalTitle="Rating"
            >
                <Rating onClick={handleRating} ratingValue={rating} stars={10} />
                <br/>
                <br/>
                <Button 
                    text="Rate"
                    clickAction={() => handlePostRating()}
                />
            </Modal>
        </div>
    )
}
