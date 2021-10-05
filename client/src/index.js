import React from 'react'
import ReactDOM from 'react-dom';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { createStore, compose, combineReducers, applyMiddleware } from "redux";
import mediasReducer from "./redux/reducers/medias/medias"
import ratingsReducer from "./redux/reducers/ratings/ratings"

import {Provider} from 'react-redux'  
import thunk from "redux-thunk";

const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

const rootReducer = combineReducers({
    medias: mediasReducer,
    ratings: ratingsReducer
});

const store = createStore(
  rootReducer,
  composeEnhancers(applyMiddleware(thunk))
);

ReactDOM.render(
    <Provider store={store}>
        <App />
    </Provider>,
  document.getElementById('root')
);

reportWebVitals();
