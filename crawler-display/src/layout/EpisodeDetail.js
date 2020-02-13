import React, { useState, useEffect } from "react";
import Axios from "axios";
import { Container } from "semantic-ui-react";

const EpisodeDetail = props => {
  const [episodeContent, setEpisodeContent] = useState({});
  useEffect(() => {
    const fetchEpisodeContent = async () => {
      const res = await Axios.get(
        `http://localhost:2000/values/${props.match.params.titleNo}/${props.match.params.hash}`
      );
      setEpisodeContent(res.data);
    };
    fetchEpisodeContent();
  }, []);
  if (episodeContent.content) {
    return (
      <div>
        {JSON.parse(episodeContent.content).map((img, i) => {
          return (
            <img
              style={{ objectFit: "cover" }}
              key={i}
              height="1000"
              width="800"
              src={`http://localhost:2000/comic${img}`}
            />
          );
        })}
      </div>
    );
  }
  return <div>Coming soon</div>;
};

export default EpisodeDetail;
