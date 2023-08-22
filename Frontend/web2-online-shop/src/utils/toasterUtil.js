import { toast } from 'react-toastify';

const success = (message = 'Success!') => {
  toast.success(message, {
    theme: 'dark',
    position: toast.POSITION.TOP_RIGHT,
  });
};

export const error = (message = 'Error!') => {
  toast.error(message, {
    theme: 'dark',
    position: toast.POSITION.TOP_RIGHT,
    progressStyle: { color: 'red' },
  });
};

export const handleError = (statusCode, errorMessage) => {
  error('Status code: ' + statusCode + '\n' + errorMessage);
};

export const handleSuccess = (message) => {
  success(message);
};

export const toasterUtil = { handleError, handleSuccess };
