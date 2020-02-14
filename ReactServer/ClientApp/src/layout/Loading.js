import React from "react";
import { Dimmer, Loader } from "semantic-ui-react";

const Loading = () => {
  return (
    <Dimmer active>
      <Loader inverted>Loading</Loader>
    </Dimmer>
  );
};

export default Loading;
